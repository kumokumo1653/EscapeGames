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
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Film1);
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Film2);
            itemArea.GetComponent<ItemListController>().pushItem(itemList.Cord);
        }
    }
}
