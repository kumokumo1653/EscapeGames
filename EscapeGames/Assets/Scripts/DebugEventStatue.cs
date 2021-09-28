using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugEventStatue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(this.GetComponent<GameDataCollection>().eventFlagList[(int)eventList.PC]);
    }
}
