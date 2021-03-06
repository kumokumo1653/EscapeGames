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
    private GameObject textArea;
    private GameDataCollection dataCollection;
    private int startSlot = 0;
    void Start()
    {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ArrowListener);
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(selectItem);
        dataCollection = player.GetComponent<GameDataCollection>();
        textArea = InheritTextArea.Instance;
        textArea = textArea.transform.Find("MessageWindow").gameObject;
        background.GetComponent<SpriteRenderer>().sprite = backgrounds[0];
        DrawItemSlot();
    }


    public void pushItem(itemList e){
        dataCollection.ItemList.Add(e);
        DrawItemSlot();
    }

    public void popItem(itemList e){
        dataCollection.ItemList.Remove(e);
        if(player.GetComponent<GameDataCollection>().selectedItem == e){
            player.GetComponent<GameDataCollection>().selectedItem = itemList.None;
        }
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
                }
            }catch(Exception e){
                ItemSlots[i].GetComponent<SpriteRenderer>().sprite = sprites[(int)itemList.None];    
            }
        }
        if(!selected){
            background.GetComponent<SpriteRenderer>().sprite = backgrounds[0];
        }
    }


    public void ArrowListener(GameObject obj, Vector2 vec2){
        if(obj.name == "RightArrow"){
            startSlot += 3;
            if(startSlot >= dataCollection.ItemList.Count){
                startSlot = 0;
            }
            DrawItemSlot();
            //????????????????????????????????????
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
            //????????????????????????????????????
            dataCollection.selectedItem = itemList.None;
        }
    }

    public void selectItem(GameObject obj, Vector2 vec2){
        for(int i = 0; i < 3; i++){
            if(obj == ItemSlots[i]){
                try{
                    //???????????????????????????????????????????????????????????????
                    if(dataCollection.selectedItem == dataCollection.ItemList[startSlot + i])
                        dataCollection.selectedItem = itemList.None;
                    else{
                        dataCollection.selectedItem = dataCollection.ItemList[startSlot + i];
                        if(dataCollection.selectedItem == itemList.Paper){
                            //sreach hasami
                            for(int j = 0; j < dataCollection.ItemList.Count;j++){
                                Debug.Log(dataCollection.ItemList[j]);
                                if(dataCollection.ItemList[j] == itemList.Scissors){
                                    //text
                                    textArea.GetComponent<TextController>().pushText(new string []{TextCollection.TextList[(int)TextList.cutPaper],TextCollection.TextList[(int)TextList.getfilm2]});
                                    //item
                                    pushItem(itemList.Film2);
                                    popItem(itemList.Paper);
                                    popItem(itemList.Scissors);
                                    break;
                                }
                            }
                        }
                    }
                }catch(Exception e){
                    dataCollection.selectedItem = itemList.None;
                }
                Debug.Log(dataCollection.selectedItem);
                DrawItemSlot();
            }
        }
    }
}
