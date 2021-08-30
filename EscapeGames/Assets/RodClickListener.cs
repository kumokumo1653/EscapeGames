using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodClickListener : MonoBehaviour
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
            //アイテム取得
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Rod);
            //イベント更新
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Screen] = status.halfWay1;

            //テキスト
            textArea.GetComponent<TextController>().pushText(TextList.getRod);

            setup.GetComponent<SetupProjectorScreen>().Setup();
            }
    }
}
