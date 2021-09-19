using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupDesk : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player;
    public Sprite[] Desks;
    public Sprite ShelfKeyHole;
    public Sprite SlidingDoorKeyHole;
    public Sprite BothKeyHole;
    public GameObject KeyHole;
    public GameObject Desk;

    public Collider2D book;
    void Start()
    {
        Player = InheritPlayer.Instance;
        Setup(); 
    }

    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.initial){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[0]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = BothKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay1){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[1]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = BothKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay2){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[2]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = BothKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay3){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[3]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = BothKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay4){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[4]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = ShelfKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay5){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[5]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = ShelfKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay6){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[6]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = ShelfKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay7){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[7]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = ShelfKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay8){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[8]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = SlidingDoorKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay9){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[9]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = SlidingDoorKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay10){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[10]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = SlidingDoorKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay11){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[11]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = SlidingDoorKeyHole;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay12){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[12]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = null;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay13){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[13]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = null;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay14){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[14]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = null;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.final){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[15]; 
            KeyHole.GetComponent<SpriteRenderer>().sprite = null;
        }


        //本　当たり判定
        //本あり
        if((int)Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] % 2 == 0){
            book.enabled = true;
        }else{
            book.enabled = false;
        }
    }
}
