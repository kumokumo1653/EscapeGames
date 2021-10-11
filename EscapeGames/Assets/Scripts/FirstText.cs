using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstText : MonoBehaviour
{
    [HideInInspector]
    public static bool done = false;
    private GameObject textArea;
    private GameObject player;


    void Start()
    {
        textArea = InheritTextArea.Instance.transform.Find("MessageWindow").gameObject;
        player = InheritPlayer.Instance;
    }
    void Update()
    {
        if(player.GetComponent<GameDataCollection>().progress == gameProgress.unplay){
            player.GetComponent<GameDataCollection>().progress = gameProgress.play;
            textArea.GetComponent<TextController>().pushText(new string[]{
                TextCollection.TextList[(int)TextList.hero1],
                TextCollection.TextList[(int)TextList.hero2],
                TextCollection.TextList[(int)TextList.hero3],
                TextCollection.TextList[(int)TextList.hero4],
                TextCollection.TextList[(int)TextList.hero6],
                TextCollection.TextList[(int)TextList.hero7],
                TextCollection.TextList[(int)TextList.hero8],
                TextCollection.TextList[(int)TextList.hero9],
            });
        }
    }

}
