using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataCollection : MonoBehaviour
{

    public List<itemList> ItemList{get; set;}
    public itemList selectedItem{get; set;}
    void Awake() {
        ItemList = new List<itemList>(); 
        selectedItem = itemList.None;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
