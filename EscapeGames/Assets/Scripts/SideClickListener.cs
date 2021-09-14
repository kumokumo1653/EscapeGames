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
                case "WhiteBoard":
                    SceneManager.LoadScene(SceneList.Desk.ToString());
                    break;
                case "Desk":
                    SceneManager.LoadScene(SceneList.ProjectorScreen.ToString());
                    break;
                case "ProjectorScreen":
                    SceneManager.LoadScene(SceneList.WaterTrash.ToString());
                    break;
                case "WaterTrash":
                    SceneManager.LoadScene(SceneList.Door.ToString());
                    break;

            }
        }
        if(obj.name == "RightSide"){
            switch (SceneManager.GetActiveScene().name) {
                case "Door":
                    SceneManager.LoadScene(SceneList.WaterTrash.ToString());
                    break;
                case "WhiteBoard":
                    SceneManager.LoadScene(SceneList.Door.ToString());
                    break;
                case "Desk":
                    SceneManager.LoadScene(SceneList.WhiteBoard.ToString());
                    break;
                case "ProjectorScreen":
                    SceneManager.LoadScene(SceneList.Desk.ToString());
                    break;
                case "WaterTrash":
                    SceneManager.LoadScene(SceneList.ProjectorScreen.ToString());
                    break;
            }
        }
        if(obj.name == "ButtomSide"){
            switch(SceneManager.GetActiveScene().name){
                case "KeyBox":
                    SceneManager.LoadScene(SceneList.Door.ToString());
                    break;
                
                case "Printer":
                    SceneManager.LoadScene(SceneList.WhiteBoard.ToString());
                    break;
                case "LockBox":
                    SceneManager.LoadScene(SceneList.WhiteBoard.ToString());
                    break;
                case "BookShelf":
                    SceneManager.LoadScene(SceneList.Desk.ToString());
                    break;
                case "Shelf":
                    SceneManager.LoadScene(SceneList.Desk.ToString());
                    break;
                case "PC":
                    SceneManager.LoadScene(SceneList.Desk.ToString());
                    break;
                case "PCSide":
                    SceneManager.LoadScene(SceneList.PC.ToString());
                    break;
                case "Drawer":
                    SceneManager.LoadScene(SceneList.Shelf.ToString());
                    break;
                case "SlidingDoor":
                    SceneManager.LoadScene(SceneList.Desk.ToString());
                    break;
                case "Calendar":
                    SceneManager.LoadScene(SceneList.WaterTrash.ToString());
                    break;
                case "Water":
                    SceneManager.LoadScene(SceneList.WaterTrash.ToString());
                    break;
                case "Trash":
                    SceneManager.LoadScene(SceneList.WaterTrash.ToString());
                    break;
            }
        }
    }
}
