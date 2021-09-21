using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupPC : MonoBehaviour
{
    private GameObject Player;
    public Sprite[] PCs;
    public GameObject PC;
    public Text text;
    public GameObject numbers;
    private GameObject[] childNumbers;

    public Collider2D login;
    public Collider2D printbutton;
    public Collider2D home;
    public Collider2D go;
    public Collider2D hint;
    // Start is called before the first frame update
    void Start()
    {
        Player = InheritPlayer.Instance;
        childNumbers = new GameObject[numbers.transform.childCount];
        for(int i = 0; i < numbers.transform.childCount; i++){
            childNumbers[i] = numbers.transform.GetChild(i).gameObject;
        }
        Setup();    
    }

    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] == status.initial){
            PC.GetComponent<SpriteRenderer>().sprite = PCs[0]; 
            text.enabled = true;
            login.enabled = true;
            printbutton.enabled = false; 
            home.enabled = false;
            go.enabled = false;
            hint.enabled = false;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<BoxCollider2D>().enabled = true;
            }
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] == status.halfWay1){
            PC.GetComponent<SpriteRenderer>().sprite = PCs[1]; 
            //login failed
            text.enabled = true;
            login.enabled = true;
            printbutton.enabled = false; 
            home.enabled = false;
            go.enabled = false;
            hint.enabled = true;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<BoxCollider2D>().enabled = true;
            }
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] == status.halfWay2){
            PC.GetComponent<SpriteRenderer>().sprite = PCs[2]; 
            //home
            text.enabled = false;
            login.enabled = false;
            printbutton.enabled = true; 
            home.enabled = false;
            go.enabled = false;
            hint.enabled = true;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<BoxCollider2D>().enabled = false;
            }
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] == status.halfWay3){
            PC.GetComponent<SpriteRenderer>().sprite = PCs[3]; 
            //print not USB
            text.enabled = false;
            login.enabled = false;
            printbutton.enabled = false; 
            home.enabled = true;
            go.enabled = false;
            hint.enabled = true;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<BoxCollider2D>().enabled = false;
            }
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] == status.halfWay4){
            //print 
            PC.GetComponent<SpriteRenderer>().sprite = PCs[4]; 
            text.enabled = false;
            login.enabled = false;
            printbutton.enabled = false; 
            home.enabled = false;
            go.enabled = true;
            hint.enabled = true;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<BoxCollider2D>().enabled = false;
            }
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] == status.halfWay5){
            PC.GetComponent<SpriteRenderer>().sprite = PCs[5]; 
            //finish print
            text.enabled = false;
            login.enabled = false;
            printbutton.enabled = false; 
            home.enabled = true;
            go.enabled = false;
            hint.enabled = true;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<BoxCollider2D>().enabled = false;
            }
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] == status.final){
            PC.GetComponent<SpriteRenderer>().sprite = PCs[6]; 
            //home
            text.enabled = false;
            login.enabled = false;
            printbutton.enabled = false; 
            home.enabled = false;
            go.enabled = false;
            hint.enabled = true;
            for(int i = 0; i < numbers.transform.childCount; i++){
                childNumbers[i].GetComponent<BoxCollider2D>().enabled = false;
            }
        }
    }
}
