using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TextCollection;

public class test : MonoBehaviour
{
    // 利便性のためにmessagewindowはstaticにしておく.
    // こうしておけばインスペクターから毎回メッセージウィンドウを選択しないで済む
    private static GameObject messagewindow; // メッセージウィンドウ(Panel)
    private GameObject player;               // プレイヤー
    public string textlist;                  // 表示テキストのEnum

    // Start is called before the first frame update
    void Start()
    {
        // 非ActiveのときFindで見つけられないのでstatic変数に入れておく.
        messagewindow = GameObject.Find("Canvas");
        messagewindow = messagewindow.transform.Find("MessageWindow").gameObject;
        if (messagewindow == null) {
            messagewindow = GameObject.Find("MessageWindow");
        }

        // コールバック関数をセット
        player = GameObject.Find("Player");
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(OnClick);
    }

    // Update is called once per frame
    void OnClick(GameObject obj, Vector2 vec2)
    {
        if (obj == this.gameObject) {
            Debug.Log(textlist + "がクリックされました.");
            TextList e = (TextList)System.Enum.Parse(typeof(TextList), textlist);
            messagewindow.GetComponent<TextController>().pushText(e);
        }
    }
}
