using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreenController : MonoBehaviour
{
    public GameObject[] GameScreens;
    
    private int now = 0;

    public void Move(string direction) {
        GameScreens[now].SetActive(false);
        
        if(direction == "right"){
            now -= 1;
        }else{
            now += 1;
        }

        if(now > 4){
            now = 0;
        }else if(now < 0){
            now = 4;
        }

        GameScreens[now].SetActive(true);
    }
}
