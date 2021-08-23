using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSample : MonoBehaviour
{

    private GameObject itemArea;

    private bool f = false;
    void Start()
    {
        itemArea = InheritItemArea.Instance;
        
    }
    void Update()
    {
        if(!f){
            f = true;
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Book);
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Ink);
            itemArea.GetComponent<ItemListController>().pushItem(itemList.DoorKey);
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Rod);
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Paper);
            itemArea.GetComponent<ItemListController>().pushItem(itemList.ShelfKey);
        }
    }
}
