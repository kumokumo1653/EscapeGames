using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBookListener : MonoBehaviour
{

    private GameObject player;
    private GameObject itemArea;
    public GameObject setup;
    void Start()
    {
       player = InheritPlayer.Instance;
       player.GetComponent<ClickEventHandler>().clickEvent.AddListener(EnterBook); 
       itemArea = InheritItemArea.Instance;
    }

    public void EnterBook(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().selectedItem == itemList.Book){
                //アイテム削除
                itemArea.GetComponent<ItemListController>().popItem(itemList.Book);
                //イベント更新
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.BookShelf] = status.final;

                int flag = 0;
                flag += player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Book] == status.initial ? 0 : 1;
                flag += 4 * (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Shelf] == status.initial ? 0 : 1);
                flag += 8 * (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.initial ? 0 : 1);

                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] = (status)(flag + 2);

                setup.GetComponent<SetupBookShelf>().Setup();
            }
        }
    }
}
