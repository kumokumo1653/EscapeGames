using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupKeyBox : MonoBehaviour
{
    private GameObject Player;
    public Sprite[] KeyBoxes;

    public GameObject KeyBox;
    public Collider2D C_DoorKey;
    public Text text;
    public GameObject numbers;

    private GameObject[] childNumbers;
    void Start() {
        Player = InheritPlayer.Instance;
        childNumbers = new GameObject[numbers.transform.childCount];
        for(int i = 0; i < numbers.transform.childCount; i++){
            childNumbers[i] = numbers.transform.GetChild(i).gameObject;
        }
        Setup();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.KeyBox] == status.initial){
            KeyBox.GetComponent<SpriteRenderer>().sprite = KeyBoxes[0]; 
            //鍵取得できないのでfalse
            C_DoorKey.enabled = false;
            text.enabled = true;

            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<CircleCollider2D>().enabled = true;
            }
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.KeyBox] == status.halfWay1){
            KeyBox.GetComponent<SpriteRenderer>().sprite = KeyBoxes[1]; 
            //鍵未取得なのでtrue
            C_DoorKey.enabled = true;
            text.enabled = false;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<CircleCollider2D>().enabled = false;
            }
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.KeyBox] == status.final){
            KeyBox.GetComponent<SpriteRenderer>().sprite = KeyBoxes[2]; 
            //鍵取得済みなのでfalse
            C_DoorKey.enabled = false;
            text.enabled = false;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<CircleCollider2D>().enabled = false;
            }
        }
    }
}
