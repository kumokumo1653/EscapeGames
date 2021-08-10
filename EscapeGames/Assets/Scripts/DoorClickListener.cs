using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorClickListener : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    void Start() {
        player = InheritPlayer.Instance;
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(DoorListener);
    }

    public void DoorListener(GameObject obj, Vector2 vec2){
        if(obj.name == this.gameObject.name){
            //キーボックスへシーン遷移
            SceneManager.LoadScene(SceneList.KeyBox.ToString());
        }
    }
}
