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
            TextList e = (TextList)System.Enum.Parse(typeof(TextList), textlist);
            messagewindow.GetComponent<TextController>().pushText(e);
        }
    }
}
