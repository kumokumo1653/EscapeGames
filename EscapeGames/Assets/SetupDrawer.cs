using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupDrawer : MonoBehaviour
{
    private GameObject Player;
    public Sprite[] drawers;

    public GameObject drawer;
    public Collider2D USB;
    public Collider2D cord;
    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }

    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Drawer] == status.initial){
            drawer.GetComponent<SpriteRenderer>().sprite = drawers[0]; 
            USB.enabled = true;
            cord.enabled = true;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Drawer] == status.halfWay1){
            //延長コード取得
            drawer.GetComponent<SpriteRenderer>().sprite = drawers[1]; 
            USB.enabled = true;
            cord.enabled = false;
            
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Drawer] == status.halfWay2){
            //USB取得
            drawer.GetComponent<SpriteRenderer>().sprite = drawers[2]; 
            USB.enabled = false;
            cord.enabled = true;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Drawer] == status.final){
            //どっちも取得
            drawer.GetComponent<SpriteRenderer>().sprite = drawers[3]; 
            USB.enabled = false;
            cord.enabled = false;
        }
    }
}
