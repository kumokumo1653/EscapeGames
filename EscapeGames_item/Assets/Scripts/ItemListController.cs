using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListController : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    //アイテムのImage画像
    private Sprite itemSprite;
    //アイテムの名前
    private string itemName;
    //アイテムのタイプ
    private ItemDataBase.ItemType itemType;
    //アイテムの情報
    private string itemInformation;

    public ItemListController(Sprite image, string itemName, ItemDataBase.ItemType itemType, string information) {
        this.itemSprite = image;
        this.itemName = itemName;
        this.itemType = itemType;
        this.itemInformation = information;
    }
 
    public Sprite GetItemSprite() {
        return itemSprite;
    }
 
    public string GetItemName() {
        return itemName;
    }
 
    public ItemDataBase.ItemType GetItemType() {
        return itemType;
    }
 
    public string GetItemInformation() {
        return itemInformation;
    }

}
