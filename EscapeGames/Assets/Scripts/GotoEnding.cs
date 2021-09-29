using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoEnding : MonoBehaviour
{
    private GameDataCollection gamedata;
    private GameObject messagewindow;

    // Start is called before the first frame update
    void Start()
    {
        gamedata = InheritPlayer.Instance.GetComponent<GameDataCollection>();
        messagewindow = InheritTextArea.Instance.transform.Find("MessageWindow").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (gamedata.progress == gameProgress.result && messagewindow.GetComponent<TextController>().getTextQueueStatus() == TextAreaStatus.Empty) {
            SceneManager.LoadScene("Ending");
        }
    }
}
