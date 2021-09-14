using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupProjectorScreen : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player;
    public Sprite[] ProjectorScreens;

    public GameObject ProjectorScreen;
    public BoxCollider2D C_Cord;
    public BoxCollider2D C_Rod;
    public BoxCollider2D C_Ring;
    public BoxCollider2D C_Screen1;
    public BoxCollider2D C_Screen2;

    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }
    
    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.initial){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[0]; 
            C_Cord.enabled = true;
            C_Rod.enabled = true;
            C_Ring.enabled = true;
            C_Screen1.enabled = false;
            C_Screen2.enabled = false;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay1){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[1]; 
            C_Cord.enabled = true;
            C_Rod.enabled = false;
            C_Ring.enabled = true;
            C_Screen1.enabled = false;
            C_Screen2.enabled = false;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay2){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[2];
            C_Cord.enabled = true;
            C_Rod.enabled = false;
            C_Ring.enabled = false;
            C_Screen1.enabled = false;
            C_Screen2.enabled = false;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay3){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[3];
            C_Cord.enabled = false;
            C_Rod.enabled = false;
            C_Ring.enabled = true;
            C_Screen1.enabled = false;
            C_Screen2.enabled = false; 
            /*if(C_Rod.enabled == true){
                C_Rod.enabled = true;
            }else{
                C_Rod.enabled = false;
            }
            if(C_Ring.enabled = true){
                C_Ring.enabled = true;
            }else{
                C_Ring.enabled = false;
            }*/
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay4){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[4]; 
            C_Cord.enabled = false;
            C_Rod.enabled = true;
            C_Ring.enabled = true;
            C_Screen1.enabled = false;
            C_Screen2.enabled = false; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay5){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[5]; 
            C_Cord.enabled = false;
            C_Rod.enabled = false;
            C_Ring.enabled = false;
            C_Screen1.enabled = true;
            C_Screen2.enabled = true; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay6){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[6]; 
            C_Cord.enabled = false;
            C_Rod.enabled = false;
            C_Ring.enabled = false;
            C_Screen1.enabled = false;
            C_Screen2.enabled = true; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay7){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[7]; 
            C_Cord.enabled = false;
            C_Rod.enabled = false;
            C_Ring.enabled = false;
            C_Screen1.enabled = true;
            C_Screen2.enabled = false; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.final){
            ProjectorScreen.GetComponent<SpriteRenderer>().sprite = ProjectorScreens[8]; 
            C_Cord.enabled = false;
            C_Rod.enabled = false;
            C_Ring.enabled = false;
            C_Screen1.enabled = false;
            C_Screen2.enabled = false; 
        }
    }
}
