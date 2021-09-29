using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen1ClickListener : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private GameObject textArea;
    private GameObject itemArea;
    public GameObject setup;
    
    void Start()
    {
        player = InheritPlayer.Instance; 
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(Screen1Click);
        textArea = InheritTextArea.Instance;
        textArea = textArea.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;
    }
    public void Screen1Click(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            //フィルム1の処理
            if(player.GetComponent<GameDataCollection>().selectedItem == itemList.Film1){
                //アイテム削除
                itemArea.GetComponent<ItemListController>().popItem(itemList.Film1);
                //イベント更新
                if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay5){
                    //スクリーンにまだ何も重ねてないとき
                    player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] = status.halfWay6;
                }else if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay7){
                    //スクリーンにフィルム2が重なっているとき
                    player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] = status.final;
                }

                setup.GetComponent<SetupProjectorScreen>().Setup();
            //フィルム2の処理
            }else if(player.GetComponent<GameDataCollection>().selectedItem == itemList.Film2){
                //アイテム削除
                itemArea.GetComponent<ItemListController>().popItem(itemList.Film2);
                //イベント更新
                if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay5){
                    //スクリーンにまだ何も重ねてないとき
                    player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] = status.halfWay7;
                }else if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] == status.halfWay6){
                    //スクリーンにフィルム1が重なっているとき
                    player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] = status.final;
                }

                setup.GetComponent<SetupProjectorScreen>().Setup();
            }else{
                textArea.GetComponent<TextController>().pushText(TextList.checkScreen2);
            }
        }
    }
}
