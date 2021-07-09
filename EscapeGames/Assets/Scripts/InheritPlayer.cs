using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritPlayer : MonoBehaviour
{
    [HideInInspector]
    public static InheritPlayer singleton;
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
