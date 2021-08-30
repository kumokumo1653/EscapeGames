using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterClickListener : MonoBehaviour
{
    /*private GameObject player;
    private GameObject itemArea;

    public Sprite[] SWater;
    public GameObject Water;

    public PolygonCollider2D C_Water;
    public PolygonCollider2D C_Water2;*/

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
            //itemArea.GetComponent<ItemListController>().pushItem(itemList.SlidingDoorKey);
            //イベント更新
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Water] = status.halfWay1;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            //player.GetComponent<GameDataCollection>().isHasInk = true;

            //テキスト
            //messagewindow.GetComponent<TextController>().pushText(TextList.getKeyOverShelf);

            setup.GetComponent<SetupWater>().Setup();
            
            /*//itemArea.GetComponent<ItemListController>().pushItem(itemList.SlidingDoorKey);
            //Debug.Log("asdf");
            //this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            
            //水道の栓を抜いたのでfalse
            C_Water.enabled = false;
            //SlidingDoorKeyを取得できるのでtrue
            C_Water2.enabled = true;
            
            //マップ内の状態を更新
            Water.GetComponent<SpriteRenderer>().sprite = SWater[1];
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Water] = status.halfWay1;
            click += 1;
        }else if(obj == this.gameObject && click == 2){
            itemArea.GetComponent<ItemListController>().pushItem(itemList.SlidingDoorKey);
            Debug.Log("asdf");

            //this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            
            //マップ内の状態を更新
            Water.GetComponent<SpriteRenderer>().sprite = SWater[2];
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Water] = status.final;
        }*/
        }

    }
}
