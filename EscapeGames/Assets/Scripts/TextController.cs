using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TextCollection;

public class TextController : MonoBehaviour
{
    private GameObject messagewindow;
    private Text text;
    private GameObject closeButton;

    // Start is called before the first frame update
    void Start()
    {
        // メッセージウィンドウと表示テキストを取得
        messagewindow = this.gameObject;
        text = messagewindow.transform.Find("Text").GetComponent<Text>();

        // メッセージウィンドウを消すボタン
        closeButton = messagewindow.transform.Find("closeButton").gameObject;
        GameObject.Find("Player").GetComponent<ClickEventHandler>().clickEvent.AddListener(disappearWindow);

        messagewindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void pushText(TextList e) {
        messagewindow.SetActive(true);
        text.text = TextCollection.TextList[(int)e];
    }

    void disappearWindow(GameObject obj, Vector2 vec2) {
        if (obj == closeButton) {
            messagewindow.SetActive(false);
        }
    }
}
