using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupWater : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player;
    public Sprite[] SWater;

    public GameObject Water;
    public PolygonCollider2D C_Water;
    public PolygonCollider2D C_Water2;
    //public BoxCollider2D C_Water2;

    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }
    // Update is called once per frame
    void Update()
    {
    
    }
    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Water] == status.initial){
            Water.GetComponent<SpriteRenderer>().sprite = SWater[0]; 
            //水道の栓を抜けるのでture
            C_Water.enabled = true;
            //SlidingDoorKeyを取得できないのでfalse
            C_Water2.enabled = false;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Water] == status.halfWay1){
            Water.GetComponent<SpriteRenderer>().sprite = SWater[1]; 
            //水道の栓を抜いたのでfalse
            C_Water.enabled = false;
            //SlidingDoorKeyを取得できるのでtrue
            C_Water2.enabled = true;
        }
        else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Water] == status.final){
            Water.GetComponent<SpriteRenderer>().sprite = SWater[2]; 
            //水道の栓を抜いたのでfalse
            C_Water.enabled = false;
            //SlidingDoorKeyを取得できないのでfalse
            C_Water2.enabled = false;
        }
    }
}
