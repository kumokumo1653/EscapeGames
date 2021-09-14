using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickInkListener : MonoBehaviour
{
    private GameObject player;
    private GameObject itemArea;
    private  GameObject messagewindow; 
    private status[] eventFlagList;
    public GameObject setup;
    void Start()
    {
        player = InheritPlayer.Instance;    
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(InkListener);
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;
    }
    public void InkListener(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            //アイテム取得
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Ink);
            //イベント更新
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] = status.halfWay3;
            player.GetComponent<GameDataCollection>().isHasInk = true;

            //テキスト
            messagewindow.GetComponent<TextController>().pushText(TextList.getInk);

            setup.GetComponent<SetupSlidingDoor>().Setup();
        }
    }
}
