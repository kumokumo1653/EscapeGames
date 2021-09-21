using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupSlidingDoor : MonoBehaviour
{
    private GameObject Player;
    public Sprite[] doors;

    public Collider2D keyHole;
    public Collider2D rightDoor;
    public Collider2D leftDoor;
    public Collider2D ink;
    public Collider2D scissors;
    public GameObject door;
    private Vector2 rightclose = new Vector2(1.19f, 0.14f);
    private Vector2 rightopen = new Vector2(-1.0f, 0.11f);
    private Vector2 leftclose = new Vector2(-3.80f, 0.16f);
    private Vector2 leftopen = new Vector2(-0.76f, 0.11f);
    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }

    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.initial){
            door.GetComponent<SpriteRenderer>().sprite = doors[0]; 
            keyHole.enabled = true;
            rightDoor.enabled = false;
            leftDoor.enabled = false;
            ink.enabled = false;
            scissors.enabled = false;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.halfWay1){
            door.GetComponent<SpriteRenderer>().sprite = doors[1]; 
            keyHole.enabled = false;
            rightDoor.enabled = true;
            leftDoor.enabled = true;
            ink.enabled = false;
            scissors.enabled = false;
            rightDoor.offset = new Vector2(rightclose.x, rightclose.y);
            leftDoor.offset = new Vector2(leftclose.x, leftclose.y);

        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.halfWay2){
            //右開け    
            door.GetComponent<SpriteRenderer>().sprite = doors[2]; 
            keyHole.enabled = false;
            rightDoor.enabled = true;
            leftDoor.enabled = false;
            ink.enabled = true;
            scissors.enabled = false;
            rightDoor.offset = new Vector2(rightopen.x, rightopen.y);

        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.halfWay3){
            //右開け    
            door.GetComponent<SpriteRenderer>().sprite = doors[3]; 
            keyHole.enabled = false;
            rightDoor.enabled = true;
            leftDoor.enabled = false;
            ink.enabled = false;
            scissors.enabled = false;
            rightDoor.offset = new Vector2(rightopen.x, rightopen.y);
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.halfWay4){
            //左開け
            door.GetComponent<SpriteRenderer>().sprite = doors[4]; 
            keyHole.enabled = false;
            rightDoor.enabled = false;
            leftDoor.enabled = true;
            ink.enabled = false;
            scissors.enabled = true;
            leftDoor.offset = new Vector2(leftopen.x, leftopen.y);
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.final){
            //左開け
            door.GetComponent<SpriteRenderer>().sprite = doors[5]; 
            keyHole.enabled = false;
            rightDoor.enabled = false;
            leftDoor.enabled = true;
            ink.enabled = false;
            scissors.enabled = false;
            leftDoor.offset = new Vector2(leftopen.x, leftopen.y);
        }
        
    }
}
