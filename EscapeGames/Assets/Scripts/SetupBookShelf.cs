using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupBookShelf : MonoBehaviour
{
    private GameObject Player;
    public Sprite[] BookShelfs;

    public GameObject BookShelf;
    public Collider2D book;
    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }

    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.BookShelf] == status.initial){
            BookShelf.GetComponent<SpriteRenderer>().sprite = BookShelfs[0]; 
            book.enabled = true;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.BookShelf] == status.final){
            BookShelf.GetComponent<SpriteRenderer>().sprite = BookShelfs[1]; 
            book.enabled = false;
        }
    }

}
