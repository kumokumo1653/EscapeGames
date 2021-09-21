using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinterController : MonoBehaviour
{
    public Sprite[] sprites;
    private GameObject player;
    private GameDataCollection gamedata;

    // Start is called before the first frame update
    void Start()
    {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(setInk);
        gamedata = player.GetComponent<GameDataCollection>();
        Setup();
    }

    public void Setup() {
        if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Printer] == status.initial) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[0];
        } else {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
        }
    }

    public void setInk(GameObject obj, Vector2 vec2) {
        if (obj == this.gameObject) {
            if (gamedata.selectedItem == itemList.Ink) {
                gamedata.eventFlagList[(int)eventList.Printer] = status.final;
                InheritItemArea.Instance.GetComponent<ItemListController>().popItem(itemList.Ink);
                Setup();
            }
        }
    }
}
