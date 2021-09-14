using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickPCListener : MonoBehaviour
{
    private GameObject player;
    public GameObject setup;
    private GameObject itemArea;
    void Start()
    {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickPC);
        

        itemArea = InheritItemArea.Instance;
    }

    public void ClickPC(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().selectedItem == itemList.USB){
                //event
                itemArea.GetComponent<ItemListController>().popItem(itemList.USB);
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PCSide] = status.final;
                setup.GetComponent<SetupPCSide>().Setup();
            }
        }
    }
}
