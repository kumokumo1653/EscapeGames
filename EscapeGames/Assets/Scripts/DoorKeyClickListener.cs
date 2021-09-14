using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKeyClickListener : MonoBehaviour
{
    private GameObject player;
    private GameObject itemArea;
    public GameObject setup;
    void Start() {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(DoorKeyListener);

        itemArea = InheritItemArea.Instance;
    }

    public void DoorKeyListener(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            itemArea.GetComponent<ItemListController>().pushItem(itemList.DoorKey);
            Debug.Log("asdf");
            //eventflagの更新
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Door] = status.final;
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.KeyBox] = status.final;

            setup.GetComponent<SetupKeyBox>().Setup();
        }
    }
}
