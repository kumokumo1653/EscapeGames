using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickShelfListener : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
       player = InheritPlayer.Instance; 
       player.GetComponent<ClickEventHandler>().clickEvent.AddListener(ClickShelf);
    }

    public void ClickShelf(GameObject obj, Vector2 vec2){
        if(obj == this.gameObject){
            SceneManager.LoadScene(SceneList.Drawer.ToString());
        }
    }
}
