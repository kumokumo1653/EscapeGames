
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
            case "C_Door":
                SceneManager.LoadScene(SceneList.KeyBox.ToString());
                break;
        }
            
        
    }
}

