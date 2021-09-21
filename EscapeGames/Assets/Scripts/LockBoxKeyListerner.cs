using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBoxKeyListerner : MonoBehaviour
{
    private LockBoxController controller;
    private GameObject itemArea;
    private GameObject messagewindow;

    // Start is called before the first frame update
    void Start()
    {
        controller = this.transform.parent.gameObject.GetComponent<LockBoxController>();
        InheritPlayer.Instance.GetComponent<ClickEventHandler>().clickEvent.AddListener(getKey);
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;
    }

    public void getKey(GameObject obj, Vector2 vec2) {
        if (obj == this.gameObject) {
            InheritPlayer.Instance.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.LockBox] = status.final;
            itemArea.GetComponent<ItemListController>().pushItem(itemList.ShelfKey);
            messagewindow.GetComponent<TextController>().pushText(TextList.getKeyOverShelf);
            controller.Setup();
            this.gameObject.GetComponent<PolygonCollider2D>().enabled = false;
        }
    }
}
