using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyStatus : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    //　アイテムを持っているかどうかのフラグ
private Dictionary<string, bool> itemFlags = new Dictionary<string, bool>();
//　アイテムデータベース
[SerializeField]
private ItemDataBase itemDataBase;
 
private void Start() {
    //　とりあえず全てのアイテムのフラグを作成
    foreach (var item in itemDataBase.GetItemDataList()) {
        itemFlags.Add(item.GetItemName(), false);
    }
    //　とりあえず適当にアイテムを持っていることにする
    itemFlags["USB"] = true;
    itemFlags["INK"] = true;
    itemFlags["KEY_DOOR"] = true;
    itemFlags["KEY_SHELF1"] = true;
    itemFlags["KEY_SHELF2"] = true;
    itemFlags["SCISSORS"] = true;
    itemFlags["FILM1"] = true;
    itemFlags["FILM2"] = true;
    itemFlags["PAPER"] = true;
    itemFlags["CORD"] = true;
    itemFlags["STICK"] = true;
    itemFlags["BOOK"] = true;
}
 
//　アイテムを所持しているかどうか
public bool GetItemFlag(string itemName) {
    return itemFlags[itemName];
}
}
