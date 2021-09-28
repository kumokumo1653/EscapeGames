using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickHomeListener : MonoBehaviour
{
    private GameObject player;
    public GameObject setup;
    void Start()
    {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickHome);
        
    }

    public void ClickHome(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PCSide] == status.final && player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Printer] == status.final){
                //success print
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] = status.final;
            }else{
                //faild print
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] = status.halfWay2;
            }
            setup.GetComponent<SetupPC>().Setup();
        } 
    }
}
