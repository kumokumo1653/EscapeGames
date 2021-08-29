using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupDesk : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player;
    public Sprite[] Desks;
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
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay1){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[1]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay2){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[2]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay3){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[3]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay4){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[4]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay5){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[5]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay6){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[6]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay7){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[7]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay8){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[8]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay9){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[9]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay10){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[10]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay11){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[11]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay12){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[12]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay13){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[13]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.halfWay14){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[14]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] == status.final){
            Desk.GetComponent<SpriteRenderer>().sprite = Desks[15]; 
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
