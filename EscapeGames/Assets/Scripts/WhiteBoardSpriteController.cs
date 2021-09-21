using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum LockBoxState
{
    Open,
    Close,
    Empty
}

enum PrinterState
{
    Pending,
    Done,
}
public class WhiteBoardSpriteController : MonoBehaviour
{
    // sprite_{LockBox State}_{Printer State}
    // - LockBox State: [O]pen [C]lose [E]mpty
    // - Printer State: [P]ending [D]one
    public Sprite sprite_O_P;
    public Sprite sprite_C_P;
    public Sprite sprite_E_P;
    public Sprite sprite_O_D;
    public Sprite sprite_C_D;
    public Sprite sprite_E_D;
    private LockBoxState lockBoxState;
    private PrinterState printerState;
    GameDataCollection gamedata;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer renderer = this.gameObject.GetComponent<SpriteRenderer>();
        this.gamedata = InheritPlayer.Instance.GetComponent<GameDataCollection>();
        
        if (this.gamedata.eventFlagList[(int)eventList.Printer] == status.final && (this.gamedata.eventFlagList[(int)eventList.PC] == status.halfWay5 || this.gamedata.eventFlagList[(int)eventList.PC] == status.final)) {
            printerState = PrinterState.Done;
        } else {
            printerState = PrinterState.Pending;
        }

        if (this.gamedata.eventFlagList[(int)eventList.LockBox] == status.initial) {
            lockBoxState = LockBoxState.Close;
        } else if (this.gamedata.eventFlagList[(int)eventList.LockBox] == status.halfWay1) {
            lockBoxState = LockBoxState.Open;
        } else {
            lockBoxState = LockBoxState.Empty;
        }

        if (printerState == PrinterState.Done) {
            switch (lockBoxState)
            {
                case LockBoxState.Open:
                    renderer.sprite = sprite_O_D;
                    break;
                case LockBoxState.Close:
                    renderer.sprite = sprite_C_D;
                    break;
                case LockBoxState.Empty:
                    renderer.sprite = sprite_E_D;
                    break;
            }
        } else if (printerState == PrinterState.Pending) {
            switch (lockBoxState)
            {
                case LockBoxState.Open:
                    renderer.sprite = sprite_O_P;
                    break;
                case LockBoxState.Close:
                    renderer.sprite = sprite_C_P;
                    break;
                case LockBoxState.Empty:
                    renderer.sprite = sprite_E_P;
                    break;
            }
        }

        InheritPlayer.Instance.GetComponent<ClickEventHandler>().clickEvent.AddListener(getPrintedPaper);
    }

    void getPrintedPaper(GameObject obj, Vector2 pos) {
        if (obj == this.gameObject && printerState == PrinterState.Done && this.gamedata.eventFlagList[(int)eventList.Printer] == status.final) {
            InheritItemArea.Instance.GetComponent<ItemListController>().pushItem(itemList.Paper);
            InheritTextArea.Instance.transform.Find("MessageWindow").gameObject.GetComponent<TextController>().pushText(TextList.getPrintingPaper);
            this.gamedata.eventFlagList[(int)eventList.Printer] = status.halfWay14; // finalの次の状態を表す

            Start();
        }
    }
}
