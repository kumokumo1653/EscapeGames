using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scissors : MonoBehaviour
{
    public GameObject get;
    public GameObject item;
    public GameObject selected;
    public GameObject selected2;//アイテムスロット内の「印刷後の紙」の選択赤枠の表示制御変数
    public GameObject paper;//アイテムスロット内の印刷後の紙オブジェクトを格納するための変数
    public GameObject film2_item;//film2を表示させるための変数

    private bool used = false;//使用済みフラグ(trueでアイテム使用済み)
    public Image image;
    public Image image2;//アイテムスロット内の印刷後の紙の表示を薄く表示する

    public Mouse mouse;

    public void popitem(){
        get.SetActive(false);
        item.SetActive(true);
        //hint.OpenDialog(detail);
    }

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

    public void CutPaper(){
        if(selected.activeSelf){
            paper.SetActive(true);
            used = true;
            
            selected.SetActive(false);
            selected2.SetActive(false);
            image.color = new Color(1.0f, 1.0f, 1.0f, 0.4f);
            image2.color = new Color(1.0f, 1.0f, 1.0f, 0.4f);
            film2_item.SetActive(true);//作成したfilm2をアイテムスロット内に表示
        }
    }

    //使用済みのアイテムの上ではカーソル変化なし
    public void OnMouseEnter(){
        if(item.activeSelf && !used){
            mouse.OnMouseEnter();
        }
    }
    
}
