using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListController : MonoBehaviour
{
    public GameObject[] ItemSlots;
    
    private int now = 0;

    public GameObject selected;

    public void Move(string direction) {
        ItemSlots[now].SetActive(false);
        
        if(direction == "right"){
            now += 1;
        }else{
            now -= 1;
        }

        if(now > 3){
            now = 0;
        }else if(now < 0){
            now = 3;
        }

        ItemSlots[now].SetActive(true);

        GameObject[] selects = GameObject.FindGameObjectsWithTag("Selected");
            //アイテムをクリックするのに連動して赤い枠の表示切替
            foreach(GameObject select in selects){
                select.SetActive(false);
                }
    }

}
