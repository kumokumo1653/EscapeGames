using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDataBase : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    //　アイテムの種類
    public enum ItemType {
        usb, 
        ink, 
        key_door,
        key_shelf1,
        key_shelf2,
        scissors,
        film1,
        film2,
        paper,
        cord,
        stick,
        book,
        Other
    }
    //　アイテムデータのリスト
    public List<ItemListController> itemDataList = new List<ItemListController>(); 
 
    void Awake() {
        //　アイテムの全情報を作成
        itemDataList.Add(new ItemListController(Resources.Load("usb", typeof(Sprite)) as Sprite, "USB", ItemType.usb, "シンプルなUSB．何かに使えそう．"));
        itemDataList.Add(new ItemListController(Resources.Load("ink", typeof(Sprite)) as Sprite, "INK", ItemType.ink, "使いかけのインク．まだ使えそう．"));
        itemDataList.Add(new ItemListController(Resources.Load("key_door", typeof(Sprite)) as Sprite, "KEY_DOOR", ItemType.key_door, "ドアのかぎ"));
        itemDataList.Add(new ItemListController(Resources.Load("key_shelf1", typeof(Sprite)) as Sprite, "KEY_SHELF1", ItemType.key_shelf1, "棚のかぎ"));
        itemDataList.Add(new ItemListController(Resources.Load("key_shelf2", typeof(Sprite)) as Sprite, "KEY_SHELF2", ItemType.key_shelf2, "棚のかぎ"));
        itemDataList.Add(new ItemListController(Resources.Load("scissors", typeof(Sprite)) as Sprite, "SCISSORS", ItemType.scissors, "普通のハサミ．"));
        itemDataList.Add(new ItemListController(Resources.Load("film1", typeof(Sprite)) as Sprite, "FILM1", ItemType.film1, "フィルム．"));
        itemDataList.Add(new ItemListController(Resources.Load("film2", typeof(Sprite)) as Sprite, "FILM2", ItemType.film2, "フィルム"));
        itemDataList.Add(new ItemListController(Resources.Load("paper", typeof(Sprite)) as Sprite, "PAPER", ItemType.paper, "印刷した紙．いびつな形が印刷されている．．．"));
        itemDataList.Add(new ItemListController(Resources.Load("cord", typeof(Sprite)) as Sprite, "CORD", ItemType.cord, "延長コード．3mはありそう．"));
        itemDataList.Add(new ItemListController(Resources.Load("stick", typeof(Sprite)) as Sprite, "STICK", ItemType.stick, "長い棒．先端がまがっている．"));
        itemDataList.Add(new ItemListController(Resources.Load("book", typeof(Sprite)) as Sprite, "BOOK", ItemType.book, "本．J科が好きそうな本だ．"));
    }
    //　全アイテムデータを返す
    public List<ItemListController> GetItemDataList() {
        return itemDataList;
    }
    //　個々のアイテムデータを返す
    public ItemListController GetItemData(string itemName) {
        foreach (var item in itemDataList) {
            if(item.GetItemName() == itemName) {
                return item;
            }
        }
        return null;
    }

}
