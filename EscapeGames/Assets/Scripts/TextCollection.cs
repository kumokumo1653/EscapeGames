using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TextList{
    sample, // デバッグ
    cube,   // デバッグ
    circle, // デバッグ
    first,
    getInk,
    LIST_LEN　//enumの長さを取得
}
public static class TextCollection 
{
    public static readonly string[] TextList = new string[]{
        "サンプルテキストです(テスト用)", // デバッグ
        "Cubeです(テスト用)",            // デバッグ
        "Circleです(テスト用)",          // デバッグ
        "ここはどこだ……?",
        "インクを手に入れた",
    };
}
