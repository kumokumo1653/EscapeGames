using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyClickListener : MonoBehaviour
{
    private GameObject player;
    private GameObject itemArea;
    void Start() {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(DoorKeyListener);

        itemArea = InheritItemArea.Instance;
    }

    public void DoorKeyListener(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            itemArea.GetComponent<ItemListController>().pushItem(itemList.DoorKey);
            Debug.Log("asdf");
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
