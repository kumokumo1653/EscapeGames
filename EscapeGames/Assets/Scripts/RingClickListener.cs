using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingClickListener : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private GameObject textArea;
    private GameObject itemArea;
    public GameObject setup;
    
    void Start()
    {
        player = InheritPlayer.Instance; 
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(CordClick);
        textArea = InheritTextArea.Instance;
        textArea = textArea.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;
    }
    public void CordClick(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().selectedItem == itemList.Rod){
                //アイテム削除
                itemArea.GetComponent<ItemListController>().popItem(itemList.Rod);
                //イベント更新
                if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay1){
                    //棒を取っているとき
                    player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] = status.halfWay2;
                }else if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay3){
                    //スクリーンが下がっているとき
                    player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] = status.halfWay5;
                }

                setup.GetComponent<SetupProjectorScreen>().Setup();
            }else{
                textArea.GetComponent<TextController>().pushText(TextList.checkScreen1);
            }
        }
    }
}
