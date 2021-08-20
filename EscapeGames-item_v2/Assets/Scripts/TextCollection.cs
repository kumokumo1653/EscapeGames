using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TextList{
    first,
    getInk,
    LIST_LEN　//enumの長さを取得
}
public static class TextCollection 
{
    public static readonly string[] TextList = new string[]{
        "ここはどこだ……?",
        "インクを手に入れた",
    };
}
