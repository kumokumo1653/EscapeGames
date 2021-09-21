using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneClickListener : MonoBehaviour
{

    // Start is called before the first frame update
    private GameObject player;
    void Start() {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(SceneListener);
    }

    public void SceneListener(GameObject obj, Vector2 vec2){
        switch(obj.name){
            case "C_KeyBox":
                SceneManager.LoadScene(SceneList.KeyBox.ToString());
                break;
            case "C_Printer":
                SceneManager.LoadScene(SceneList.Printer.ToString());
                break;
            case "C_LockBox":
                SceneManager.LoadScene(SceneList.LockBox.ToString());
                break;
            case "C_BookShelf":
                SceneManager.LoadScene(SceneList.BookShelf.ToString());
                break;
            case "C_Shelf":
                SceneManager.LoadScene(SceneList.Shelf.ToString());
                break;
            case "C_PC":
                SceneManager.LoadScene(SceneList.PC.ToString());
                break;
            case "C_SlidingDoor":
                SceneManager.LoadScene(SceneList.SlidingDoor.ToString());
                break;
            case "C_Calendar":
                SceneManager.LoadScene(SceneList.Calendar.ToString());
                break;
            case "C_Trash":
                SceneManager.LoadScene(SceneList.Trash.ToString());
                break;
            case "C_Water":
                SceneManager.LoadScene(SceneList.Water.ToString());
                break;
            case "C_Side":
                SceneManager.LoadScene(SceneList.PCSide.ToString());
                break;
        }
            
        
    }
}

