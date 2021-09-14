using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupPCSide : MonoBehaviour
{

    private GameObject player;
    public Sprite[] PCSides;
    public GameObject PCSide;
    public Collider2D side;
    void Start()
    {
        player = InheritPlayer.Instance;
        Setup();
    }

    public void Setup(){
        if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PCSide] == status.initial){
            PCSide.GetComponent<SpriteRenderer>().sprite = PCSides[0]; 
            side.enabled = true;
        }else if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PCSide] == status.final){
            PCSide.GetComponent<SpriteRenderer>().sprite = PCSides[1]; 
            side.enabled = false;
        }
    }


}
