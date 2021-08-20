using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usb : MonoBehaviour
{
    public GameObject get;
    public GameObject item;
    public GameObject selected;

    public void popitem(){
        get.SetActive(false);
        item.SetActive(true);
        //hint.OpenDialog(detail);
    }

    public void selectitem(){
        if(item.activeSelf){
            //FindGameObjectsWithTagは，「同じタグがついたアクティブな状態の
            //オブジェクトをまとめて取得」する
            //(Selectedタグがついたオブジェクトをまとめて取得)
            GameObject[] selects = GameObject.FindGameObjectsWithTag("Selected");
            //アイテムをクリックするのに連動して赤い枠の表示切替
            foreach(GameObject select in selects){
                select.SetActive(false);
                }
                selected.SetActive(true);
        }
    }
}
