using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickLoginListener : MonoBehaviour
{
    private GameObject player;
    public GameObject setup;
    public Text numbers;

    // Start is called before the first frame update
    void Start()
    {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickLogin);
    }

    public void ClickLogin(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            if(numbers.text == "  1   0    2   2"){
                //成功
                //event

                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] = status.halfWay2;
            }else{
                //failed
                player.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC] = status.halfWay1;
            }

            setup.GetComponent<SetupPC>().Setup();
        }
    }
        
}
