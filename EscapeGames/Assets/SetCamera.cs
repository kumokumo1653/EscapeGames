using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCamera : MonoBehaviour
{
    private GameObject Camera;
    void Start() {
        Camera = InheritCamera.Instance;
        this.gameObject.GetComponent<Canvas>().worldCamera = Camera.GetComponent<Camera>();
        
    }

}
