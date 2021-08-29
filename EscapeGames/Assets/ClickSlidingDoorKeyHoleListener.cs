using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSlidingDoorKeyHoleListener : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private GameObject textArea;
    private GameObject itemArea;
    public GameObject setup;
    
    void Start()
    {
        player = InheritPlayer.Instance; 
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickSlidingDoorKeyHole);
        textArea = InheritTextArea.Instance;
        textArea = textArea.transform.Find("MessageWindow").gameObject;

        itemArea = InheritItemArea.Instance;
    }
    public void ClickSlidingDoorKeyHole(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().selectedItem == itemList.SlidingDoorKey){
                //アイテム削除
                itemArea.GetComponent<ItemListController>().popItem(itemList.SlidingDoorKey);
                //解錠
                textArea.GetComponent<TextController>().pushText(TextList.openDoor);
                //イベント更新
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] = status.halfWay1;

                int flag = 0;
                flag += (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Book] == status.initial ? 0 : 1);
                flag += 2 * (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.BookShelf] == status.initial ? 0 : 1);
                flag += 4 * (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Shelf] == status.initial ? 0 : 1);
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Desk] = (status)(flag + 8);

                setup.GetComponent<SetupSlidingDoor>().Setup();
            }else{
                textArea.GetComponent<TextController>().pushText(TextList.checkKey);
            }
        }
    }
}
