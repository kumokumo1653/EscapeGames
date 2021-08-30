using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEventListener : MonoBehaviour
{
    // 利便性のためにmessagewindowはstaticにしておく.
    // こうしておけばインスペクターから毎回メッセージウィンドウを選択しないで済む
    private  GameObject messagewindow; // メッセージウィンドウ(Panel)
    private  GameObject player;               // プレイヤー
    public string textlist;                  // 表示テキストのEnum
    public string multitextlist;            // 表示テキストのEnum｡二回連続以上のもの｡

    void Start()
    {
        //canvasの取得
        messagewindow = InheritTextArea.Instance;
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        if (messagewindow == null) {
            messagewindow = GameObject.Find("MessageWindow");
        }

        // コールバック関数をセット
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(OnClick);
    }

    // Update is called once per frame
    void OnClick(GameObject obj, Vector2 vec2)
    {
        if (obj == this.gameObject) {
            //Debug.Log(textlist + "がクリックされました.");
            if (!System.String.IsNullOrEmpty(this.textlist)) {
                TextList e = (TextList)System.Enum.Parse(typeof(TextList), textlist);
                messagewindow.GetComponent<TextController>().pushText(e);
            } else if (!System.String.IsNullOrEmpty(this.multitextlist)) {
                MultiTextList e = (MultiTextList)System.Enum.Parse(typeof(MultiTextList), this.multitextlist);
                messagewindow.GetComponent<TextController>().pushText(e);
            }
        }
    }
}
