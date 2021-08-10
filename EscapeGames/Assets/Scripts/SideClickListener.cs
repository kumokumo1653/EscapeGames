using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SideClickListener : MonoBehaviour
{
    //画面の矢印でシーン遷移する用
    private GameObject player;
    void Start() {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(SideListener);
    }

    public void SideListener(GameObject obj, Vector2 vec2){
        if(obj.name == "LeftSide"){
            switch (SceneManager.GetActiveScene().name) {
                case "Door":
                    SceneManager.LoadScene(SceneList.WhiteBoard.ToString());
                    break;
            }
        }
        if(obj.name == "RightSide"){
            switch (SceneManager.GetActiveScene().name) {
                case "WhiteBoard":
                    SceneManager.LoadScene(SceneList.Door.ToString());
                    break;
            }
        }
    }
}
