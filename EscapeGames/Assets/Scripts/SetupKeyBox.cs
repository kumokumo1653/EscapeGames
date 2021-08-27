using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupKeyBox : MonoBehaviour
{
    private GameObject Player;
    public Sprite[] KeyBoxes;

    public GameObject KeyBox;
    public BoxCollider2D C_DoorKey;
    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.KeyBox] == status.initial){
            KeyBox.GetComponent<SpriteRenderer>().sprite = KeyBoxes[0]; 
            //鍵取得できないのでfalse
            C_DoorKey.enabled = false;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.KeyBox] == status.halfWay1){
            KeyBox.GetComponent<SpriteRenderer>().sprite = KeyBoxes[1]; 
            //鍵未取得なのでtrue
            C_DoorKey.enabled = true;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.KeyBox] == status.final){
            KeyBox.GetComponent<SpriteRenderer>().sprite = KeyBoxes[2]; 
            //鍵取得済みなのでfalse
            C_DoorKey.enabled = false;
        }
    }
}
