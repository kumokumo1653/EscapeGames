using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritCamera : MonoBehaviour
{
    [HideInInspector]
    public static InheritCamera singleton;
    public static GameObject Instance{get{return singleton.gameObject;}}
    void Awake() {
        if (singleton == null) {
                DontDestroyOnLoad (this.gameObject);
                singleton = this;
            //　既にGameStartスクリプトがあればこのシーンの同じゲームオブジェクトを削除
        } else {
            Destroy (gameObject);
        }
    }
}
