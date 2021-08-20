using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D cursor;

    private Vector2 hotspot = new Vector2(10,4);//「ホットスポット」を画像のどの場所にするかの設定 

    //カーソルをかざしたとき
    public void OnMouseEnter(){
        Cursor.SetCursor(cursor, hotspot, CursorMode.ForceSoftware);
    }

    //カーソルをかざさないとき
    public void OnMouseExit(){
        Cursor.SetCursor(null, hotspot, CursorMode.ForceSoftware);
    }
}
