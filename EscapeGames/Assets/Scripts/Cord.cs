using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cord : MonoBehaviour
{
    public GameObject get;
    public GameObject item;
    public GameObject selected;
    public GameObject connect_first;
    public GameObject connect_last;

    private bool used = false;//使用済みフラグ(trueでアイテム使用済み)
    public Image image;

    public Mouse mouse;

    public void popitem(){
        get.SetActive(false);
        item.SetActive(true);
        //hint.OpenDialog(detail);
    }

    //アイテム選択
    public void selectitem(){
        if(item.activeSelf && !used){
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

    //ユーザがスクリーンをおろす行動を(コードをつなぐことよりも)先にした場合
    public void ConnectCordFirst(){
        if(selected.activeSelf){
            connect_first.SetActive(true);
            //down_last.SetActive(true);

            used = true;
            selected.SetActive(false);
            image.color = new Color(1.0f, 1.0f, 1.0f, 0.4f);
        }
    }
    
    //ユーザがスクリーンをおろす行動を後にした場合
    public void ConnectCordLast(){
        if(selected.activeSelf){
            connect_last.SetActive(true);
            //down_last.SetActive(true);

            used = true;
            selected.SetActive(false);
            image.color = new Color(1.0f, 1.0f, 1.0f, 0.4f);
        }
    }

    //使用済みのアイテムの上ではカーソル変化なし
    public void OnMouseEnter(){
        if(item.activeSelf && !used){
            mouse.OnMouseEnter();
        }
    }
}
