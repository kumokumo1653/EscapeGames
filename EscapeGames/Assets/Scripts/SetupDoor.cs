using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupDoor : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player;
    public Sprite[] Doors;

    public GameObject Door;
    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }

    void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Door] == status.initial){
            Door.GetComponent<SpriteRenderer>().sprite = Doors[0]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Door] == status.halfWay1){
            Door.GetComponent<SpriteRenderer>().sprite = Doors[1]; 
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Door] == status.final){
            Door.GetComponent<SpriteRenderer>().sprite = Doors[2]; 
        }
    }

}
