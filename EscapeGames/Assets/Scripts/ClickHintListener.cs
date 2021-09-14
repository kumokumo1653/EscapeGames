using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;

public class ClickHintListener : MonoBehaviour
{
    // Start is called before the first frame update
        private GameObject player;
    private GameObject textArea;
    private eventList[] unachievedFlag = new eventList[0];
    void Start()
    {
        player = InheritPlayer.Instance; 
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickHint);
        textArea = InheritTextArea.Instance;
        textArea = textArea.transform.Find("MessageWindow").gameObject;
    }

    // Update is called once per frame
    public void ClickHint(GameObject obj, Vector2 vec2){
        eventList pushHint;
        if(obj == this.gameObject){
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.KeyBox] == status.initial){
                Array.Resize(ref unachievedFlag, unachievedFlag.Length + 1);
                unachievedFlag[unachievedFlag.Length - 1] = eventList.KeyBox;
            }
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.LockBox] == status.initial){
                Array.Resize(ref unachievedFlag, unachievedFlag.Length + 1);
                unachievedFlag[unachievedFlag.Length - 1] = eventList.LockBox;
            }
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Printer] == status.initial){
                Array.Resize(ref unachievedFlag, unachievedFlag.Length + 1);
                unachievedFlag[unachievedFlag.Length - 1] = eventList.Printer;
            }
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] != status.final){
                Array.Resize(ref unachievedFlag, unachievedFlag.Length + 1);
                unachievedFlag[unachievedFlag.Length - 1] = eventList.PC;
            }
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Projector] != status.final){
                Array.Resize(ref unachievedFlag, unachievedFlag.Length + 1);
                unachievedFlag[unachievedFlag.Length - 1] = eventList.Projector;
            }
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Water] == status.initial){
                Array.Resize(ref unachievedFlag, unachievedFlag.Length + 1);
                unachievedFlag[unachievedFlag.Length - 1] = eventList.Water;
            }
            pushHint = (unachievedFlag.OrderBy(i => System.Guid.NewGuid()).ToArray())[0];
            if(pushHint == eventList.KeyBox){
                textArea.GetComponent<TextController>().pushText(TextList.hint1);
            }
            if(pushHint == eventList.LockBox){
                textArea.GetComponent<TextController>().pushText(TextList.hint2);
            }
            if(pushHint == eventList.Printer){
                textArea.GetComponent<TextController>().pushText(TextList.hint2_1);
            }
            if(pushHint == eventList.PC){
                textArea.GetComponent<TextController>().pushText(TextList.hint3);
            }
            if(pushHint == eventList.Projector){
                textArea.GetComponent<TextController>().pushText(TextList.hint4);
            }
            if(pushHint == eventList.Water){
                textArea.GetComponent<TextController>().pushText(TextList.hint5);
            }
        }
    }
}
