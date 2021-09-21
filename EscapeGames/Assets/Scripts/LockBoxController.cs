using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBoxController : MonoBehaviour
{
    private LockBox display1;
    private LockBox display2;
    private LockBox display3;
    private LockBox display4;
    private GameObject obj_display1;
    private GameObject obj_display2;
    private GameObject obj_display3;
    private GameObject obj_display4;
    private GameObject player;
    private GameObject lockbox;
    private GameObject key;
    private GameObject messagewindow;
    private GameObject itemArea;
    private int ans = 5301;
    private int dial = 0;
    public Sprite[] sprites;

    void Start()
    {
        display1 = this.transform.Find("LockBoxDisplay1").gameObject.GetComponent<LockBox>();
        display2 = this.transform.Find("LockBoxDisplay2").gameObject.GetComponent<LockBox>();
        display3 = this.transform.Find("LockBoxDisplay3").gameObject.GetComponent<LockBox>();
        display4 = this.transform.Find("LockBoxDisplay4").gameObject.GetComponent<LockBox>();

        obj_display1 = this.transform.Find("LockBoxDisplay1").gameObject;
        obj_display2 = this.transform.Find("LockBoxDisplay2").gameObject;
        obj_display3 = this.transform.Find("LockBoxDisplay3").gameObject;
        obj_display4 = this.transform.Find("LockBoxDisplay4").gameObject;
        lockbox = this.transform.parent.gameObject;
        key = this.transform.Find("key").gameObject;
        player = InheritPlayer.Instance;
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        itemArea = InheritItemArea.Instance;

        Setup();
    }

    private int getDial() {
        return display1.display * 1000 + display2.display * 100 + display3.display * 10 + display4.display;
    }

    public void checkStatus() {
        dial = getDial();
        if (dial == ans) {
            player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.LockBox] = status.halfWay1;
            messagewindow.GetComponent<TextController>().pushText(TextList.openBox);

            Setup();
        }
    }

    public void Setup() {
        if (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.LockBox] == status.initial) {
            lockbox.GetComponent<SpriteRenderer>().sprite = sprites[0];
            key.SetActive(false);
        } else if (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.LockBox] == status.halfWay1) {
            lockbox.GetComponent<SpriteRenderer>().sprite = sprites[1];

            obj_display1.GetComponent<LockBox>().display = -1;
            obj_display1.GetComponent<LockBox>().updateDisplay();
            obj_display2.GetComponent<LockBox>().display = -1;
            obj_display2.GetComponent<LockBox>().updateDisplay();
            obj_display3.GetComponent<LockBox>().display = -1;
            obj_display3.GetComponent<LockBox>().updateDisplay();
            obj_display4.GetComponent<LockBox>().display = -1;
            obj_display4.GetComponent<LockBox>().updateDisplay();

            key.SetActive(true);
        } else if (player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.LockBox] == status.final) {
            lockbox.GetComponent<SpriteRenderer>().sprite = sprites[2];
            obj_display1.GetComponent<LockBox>().display = -1;
            obj_display1.GetComponent<LockBox>().updateDisplay();
            obj_display2.GetComponent<LockBox>().display = -1;
            obj_display2.GetComponent<LockBox>().updateDisplay();
            obj_display3.GetComponent<LockBox>().display = -1;
            obj_display3.GetComponent<LockBox>().updateDisplay();
            obj_display4.GetComponent<LockBox>().display = -1;
            obj_display4.GetComponent<LockBox>().updateDisplay();

            key.SetActive(false);
        }
    }
}
