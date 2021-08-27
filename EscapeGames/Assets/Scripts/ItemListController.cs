using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class ItemListController : MonoBehaviour
{

    public Sprite[] sprites = new Sprite[13];

    public GameObject[] ItemSlots = new GameObject[3];

    public GameObject background;

    public Sprite[] backgrounds = new Sprite[4];
    private GameObject player;
    private GameDataCollection dataCollection;
    private int startSlot = 0;
    void Start()
    {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ArrowListener);
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(selectItem);
        dataCollection = player.GetComponent<GameDataCollection>();
        background.GetComponent<SpriteRenderer>().sprite = backgrounds[0];
        DrawItemSlot();
    }


    public void pushItem(itemList e){
        dataCollection.ItemList.Add(e);
        DrawItemSlot();
    }

    public void popItem(itemList e){
        dataCollection.ItemList.Remove(e);
        DrawItemSlot();
    }

    private void DrawItemSlot(){
        bool selected = false;
        for(int i = 0; i < 3; i++){
            try{
                ItemSlots[i].GetComponent<SpriteRenderer>().sprite = sprites[(int)dataCollection.ItemList[startSlot + i]];
                if(dataCollection.ItemList[startSlot + i] == dataCollection.selectedItem){
                    selected = true;
                    background.GetComponent<SpriteRenderer>().sprite = backgrounds[i + 1];
                }else if(!selected)
                    background.GetComponent<SpriteRenderer>().sprite = backgrounds[0];
            }catch(Exception e){
                ItemSlots[i].GetComponent<SpriteRenderer>().sprite = sprites[(int)itemList.None];    
            }
        }
    }


    public void ArrowListener(GameObject obj, Vector2 vec2){
        if(obj.name == "RightArrow"){
            startSlot += 3;
            if(startSlot >= dataCollection.ItemList.Count){
                startSlot = 0;
            }
            DrawItemSlot();
            //アイテムの選択状態を解除
            dataCollection.selectedItem = itemList.None;
        }else if(obj.name == "LeftArrow"){
            startSlot -= 3;
            if(startSlot < 0){
                if(dataCollection.ItemList.Count % 3 == 0){
                    startSlot = (dataCollection.ItemList.Count / 3 - 1) * 3;
                }else{
                    startSlot = (dataCollection.ItemList.Count / 3) * 3;
                }
            }
            DrawItemSlot();
            //アイテムの選択状態を解除
            dataCollection.selectedItem = itemList.None;
        }
    }

    public void selectItem(GameObject obj, Vector2 vec2){
        for(int i = 0; i < 3; i++){
            if(obj == ItemSlots[i]){
                try{
                    //同じアイテムを選択状態だったら非選択状態に
                    if(dataCollection.selectedItem == dataCollection.ItemList[startSlot + i])
                        dataCollection.selectedItem = itemList.None;
                    else
                        dataCollection.selectedItem = dataCollection.ItemList[startSlot + i];
                }catch(Exception e){
                    dataCollection.selectedItem = itemList.None;
                }
                Debug.Log(dataCollection.selectedItem);
                DrawItemSlot();
            }
        }
    }
}
