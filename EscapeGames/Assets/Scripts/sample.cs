using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    void Start() {
        player.GetComponent<ClickEventHandler>().clickEvent.AddListener(sampele);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void sampele(GameObject obj, Vector2 vec2){
        Debug.Log(obj.name);
        Debug.Log(vec2);
    }
}
