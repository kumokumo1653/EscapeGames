using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Film1ClickListener : MonoBehaviour
{
    private GameObject player;
    private GameObject itemArea;
    void Start() {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(Film1Listener);

        itemArea = InheritItemArea.Instance;
    }

    public void Film1Listener(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Film1);
            //Debug.Log("asdf");
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
