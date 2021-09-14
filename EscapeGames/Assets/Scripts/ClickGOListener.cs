using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickGOListener : MonoBehaviour
{
    private GameObject player;
    public GameObject setup;
    void Start()
    {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickGO);
        
    }

    public void ClickGO(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] = status.halfWay5;
            setup.GetComponent<SetupPC>().Setup();
        } 
    }
}
