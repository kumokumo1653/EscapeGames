using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoorKeyClickListener : MonoBehaviour
{
    private GameObject player;
    private GameObject itemArea;
    private  GameObject messagewindow; 
    private status[] eventFlagList;
    public GameObject setup;
    
    void Start() {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(WaterListener);
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;
    }

    public void WaterListener(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            //アイテム取得
            itemArea.GetComponent<ItemListController>().pushItem(itemList.SlidingDoorKey);
            //イベント更新
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Water] = status.final;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            //player.GetComponent<GameDataCollection>().isHasInk = true;
            //テキスト
            messagewindow.GetComponent<TextController>().pushText(TextList.getKeyOverShelf);
            setup.GetComponent<SetupWater>().Setup();
            }
    }
}
