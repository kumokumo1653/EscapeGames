using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLeftSlidingDoorListener : MonoBehaviour
{
    private GameObject player;
    public GameObject setup;
    
    void Start()
    {
        player = InheritPlayer.Instance; 
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickLeftSlidingDoor);
    }
    public void ClickLeftSlidingDoor(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            //イベント更新
            if(player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] == status.halfWay1){
                //閉まった状態から
                if(player.GetComponent<GameDataCollection>().isHasScissors){
                    //ハサミ取得済み
                    player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] = status.final;
                }else{

                    player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] = status.halfWay4;
                }
            }else{
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.SlidingDoor] = status.halfWay1;
            }
            setup.GetComponent<SetupSlidingDoor>().Setup();
        }
    }
}
