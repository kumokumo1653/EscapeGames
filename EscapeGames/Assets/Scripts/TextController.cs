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
    private List<string> text_queue;

    // Start is called before the first frame update
    void Awake()
    {
        // メッセージウィンドウと表示テキストを取得
        messagewindow = this.gameObject;
        text = messagewindow.transform.Find("Text").GetComponent<Text>();
        this.text_queue = new List<string>();

        // メッセージウィンドウを消すボタン
        // このボタンを透明にして画面全体に写すことで画面のどこかをクリックすると
        // メッセージの表示が消える.
        closeButton = messagewindow.transform.Find("closeButton").gameObject;
        GameObject.Find("Player").GetComponent<ClickEventHandler>().clickEvent.AddListener(disappearWindow);

        messagewindow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void flushMessageWindow() {
        if (text_queue.Count > 0) {
            messagewindow.SetActive(true);
            text.text = text_queue[0];
            text_queue.RemoveAt(0);
        } else {
            messagewindow.SetActive(false);
        }
    }

    public void pushText(TextList e) {
        Debug.Log(text_queue);
        Debug.Log(TextCollection.TextList[(int)e]);
        text_queue.Add(TextCollection.TextList[(int)e]);
        this.flushMessageWindow();
    }

    public void pushText(string[] text) {
        for(int i = 0;i < text.Length; i++) {
            this.text_queue.Add(text[i]);
        }
        this.flushMessageWindow();
    }

    public void pushText(string text) {
        this.text_queue.Add(text);
        this.flushMessageWindow();
    }

    public void pushText(MultiTextList e) {
        var text = MultiTextCollection.MultiTextList[(int)e];
        for(int i = 0;i < text.Length; i++) {
            this.text_queue.Add(text[i]);
        }
        this.flushMessageWindow();
    }

    void disappearWindow(GameObject obj, Vector2 vec2) {
        if (obj == closeButton) {
            this.flushMessageWindow();
        }
    }
}

public enum MultiTextList {
    test1,
    LIST_LEN
}

public static class MultiTextCollection {
    public static readonly List<string[]> MultiTextList = new List<string[]>
    {
        new string[] {"test1", "test2"}
    };
}