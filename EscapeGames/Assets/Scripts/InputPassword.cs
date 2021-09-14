using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPassword : MonoBehaviour
{
    private string selectNumbers = "";
    private GameObject Player;
    public Text Numbers; 
    public int maxLength;
    public int maxNumbers;

    public GameObject Setup;

    void Start()
    {
        Player = InheritPlayer.Instance;
        Player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickNumber);
    }

    void ClickNumber(GameObject obj, Vector2 vec2){
        int num;
        
        //nameがint変換できるか
        if(int.TryParse(obj.name, out num)){
            if(selectNumbers.Length < maxNumbers){
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
                Numbers.text += "   ";
            }

        }
        //5文字入れてないときは13文字目まで空白で埋める。
        Numbers.text.PadRight(maxLength);
    }

}
