using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupShelf : MonoBehaviour
{
    private GameObject Player;
    public Sprite[] shelfs;

    public GameObject shelf;
    public Collider2D keyhole;
    public Collider2D drawer;
    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }

    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Shelf] == status.initial){
            shelf.GetComponent<SpriteRenderer>().sprite = shelfs[0]; 
            keyhole.enabled = true;
            drawer.enabled = false;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.Shelf] == status.final){
            shelf.GetComponent<SpriteRenderer>().sprite = shelfs[1]; 
            keyhole.enabled = false;
            drawer.enabled = true;
        }
    }
}
