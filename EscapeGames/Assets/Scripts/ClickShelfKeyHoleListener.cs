using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickShelfKeyHoleListener : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private GameObject textArea;
    private GameObject itemArea;
    public GameObject setup;
    
    void Start()
    {
        player = InheritPlayer.Instance; 
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickShelfKeyHole);
        textArea = InheritTextArea.Instance;
        textArea = textArea.transform.Find("MessageWindow").gameObject;

        itemArea = InheritItemArea.Instance;
    }

    public void ClickShelfKeyHole(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().selectedItem == itemList.ShelfKey){
                //アイテム削除
                itemArea.GetComponent<ItemListController>().popItem(itemList.ShelfKey);
                //解錠
                textArea.GetComponent<TextController>().pushText(TextList.openDoor);
                //イベント更新
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Shelf] = status.final;

                int flag = 0;
                flag += (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Book] == status.initial ? 0 : 1);
                flag += 2 * (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.BookShelf] == status.initial ? 0 : 1);
                flag += 8 * (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.initial ? 0 : 1);
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] = (status)(flag + 4);

                setup.GetComponent<SetupShelf>().Setup();
            }else{
                textArea.GetComponent<TextController>().pushText(TextList.checkKey);
            }
        }
    }
}
