using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashClickListener : MonoBehaviour
{
    /*private GameObject player;
    private GameObject itemArea;

    public Sprite[] Trashes;
    public GameObject Trash;*/

    private GameObject player;
    private GameObject itemArea;
    private  GameObject messagewindow; 
    private status[] eventFlagList;
    public GameObject setup;

    //private bool used = false;//使用済みフラグ(trueでアイテム使用済み)

    void Start() {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(TrashListener);
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;
    }

    public void TrashListener(GameObject obj, Vector2 vec2){
        //if((obj == this.gameObject) && !used){
        if(obj == this.gameObject){
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Film1);
            player.GetComponent<GameDataCollection>().eventFlagList[(int)itemList.Film1] = status.final;
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
            
            //マップ内のアイテムの状態を更新
            //used = true;
            //Trash.GetComponent<SpriteRenderer>().sprite = Trashes[1]; 
            //テキスト
            messagewindow.GetComponent<TextController>().pushText(TextList.getFilm1);
            setup.GetComponent<SetupTrash>().Setup();
        }
    }
}
