using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InputNumbers : MonoBehaviour
{
    private string selectNumbers = "";
    private GameObject Player;
    public Text Numbers; 

    void Start()
    {
        Player = InheritPlayer.Instance;
        Player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickNumber);
    }

    void ClickNumber(GameObject obj, Vector2 vec2){
        int num;
        
        if(int.TryParse(obj.name, out num)){
            if(selectNumbers.Length < 5){
                selectNumbers += num;
                UpdateNumbers();
            }
        }else if(obj.name == "BS"){
            if(selectNumbers.Length > 0){
                selectNumbers = selectNumbers.Substring(0,selectNumbers.Length - 1);
                UpdateNumbers();
            }
        }
    }

    void UpdateNumbers(){
        Numbers.text = "  ";
        for(int i = 0; i < selectNumbers.Length;i++){
            Numbers.text += selectNumbers[i];
            if(i != selectNumbers.Length - 1){
                Numbers.text += "  ";
            }

        }
        //5文字入れてないときは13文字目まで空白で埋める。
        Numbers.text.PadRight(13);
    }

}
