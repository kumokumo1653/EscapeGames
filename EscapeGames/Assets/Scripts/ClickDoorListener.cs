using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickDoorListener : MonoBehaviour
{
    private GameObject player;
    private  GameObject messagewindow; 
    void Start()
    {
        player = InheritPlayer.Instance;    
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(DoorListener);
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
    }

    public void DoorListener(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().selectedItem == itemList.DoorKey){

                messagewindow.GetComponent<TextController>().pushText(TextList.openDoor);
                player.GetComponent<GameDataCollection>().progress = gameProgress.result;
            }else{
                messagewindow.GetComponent<TextController>().pushText(TextList.checkKey);
            }
        }
    }

}
