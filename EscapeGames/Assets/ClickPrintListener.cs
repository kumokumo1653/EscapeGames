using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPrintListener : MonoBehaviour
{
    private GameObject player;
    public GameObject setup;
    void Start()
    {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickPrint);
        
    }

    public void ClickPrint(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PCSide] == status.final){
                //success
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] = status.halfWay4;
            }else{
                //faild
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] = status.halfWay3;
            }
            setup.GetComponent<SetupPC>().Setup();
        }
        
    }
}
