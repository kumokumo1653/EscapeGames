using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickBookListener : MonoBehaviour
{
    private GameObject player;
    private GameObject itemArea;
    private  GameObject messagewindow; 
    private status[] eventFlagList;
    public GameObject setup;
    void Start()
    {
        player = InheritPlayer.Instance;    
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(BookListener);
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;
    }

    public void BookListener(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            eventFlagList = player.GetComponent<GameDataCollection>().eventFlagList;
            messagewindow.GetComponent<TextController>().pushText(TextList.getBook);
            //エベント更新
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Book] = status.final;
            int flag = 0;
            //本棚
            flag += 2 * (eventFlagList[(int)eventList.BookShelf] == status.initial ? 0 : 1);
            //引き出し
            flag += 4 * (eventFlagList[(int)eventList.Shelf] == status.initial ? 0 : 1);
            //スライド
            flag += 8 * (eventFlagList[(int)eventList.SlidingDoor] == status.initial ? 0 : 1);

            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] = (status)(flag + 1);

            //アイテム取得
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Book);

            setup.GetComponent<SetupDesk>().Setup();
        }
    }

}
