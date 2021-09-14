using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCordListener : MonoBehaviour
{
    private GameObject player;
    private GameObject itemArea;
    private  GameObject messagewindow; 
    private status[] eventFlagList;
    public GameObject setup;
    void Start()
    {
        player = InheritPlayer.Instance;    
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(CordListener);
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;
    }
    public void CordListener(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            //アイテム取得
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Cord);
            //イベント更新
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Drawer] == status.initial)
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Drawer] = status.halfWay1;
            else 
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Drawer] = status.final;

            //テキスト
            messagewindow.GetComponent<TextController>().pushText(TextList.getCord);

            setup.GetComponent<SetupDrawer>().Setup();
        }
    }
}
