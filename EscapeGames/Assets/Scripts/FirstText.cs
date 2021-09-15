using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstText : MonoBehaviour
{
    [HideInInspector]
    public static bool done = false;

    void Start() {
        if (!done) {
            DontDestroyOnLoad (this.gameObject);
            InheritTextArea.Instance.transform.Find("MessageWindow").gameObject.GetComponent<TextController>().pushText( new string[] {
                "てきすと1",
                "てきすと2"
            });
            done = true;
        }
    }
}
