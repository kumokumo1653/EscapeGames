using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataCollection : MonoBehaviour
{

    public List<itemList> ItemList{get; set;}
    public itemList selectedItem{get; set;}

    public status[] eventFlagList{get;set;}
    void Awake() {
        ItemList = new List<itemList>(); 
        selectedItem = itemList.None;
        eventFlagList = new status[(int)eventList.LIST_LEN];
        for(int i = 0; i < (int)eventList.LIST_LEN; i++){
            eventFlagList[i] = status.initial;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
