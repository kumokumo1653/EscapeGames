using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

[System.Serializable]
public class ClickEvent : UnityEvent<GameObject, Vector2>{ }
public class ClickEventHandler : MonoBehaviour {
    [HideInInspector]
    public ClickEvent clickEvent;
    public Camera camera_object; //カメラを取得
   
	void Update () {
		//左クリックでレイを飛ばす 
		if (Input.GetMouseButtonDown(0)) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

			if (hit2d) {
				clickEvent.Invoke(hit2d.transform.gameObject, Camera.main.ScreenToWorldPoint(Input.mousePosition));
			} 
			
		}  
	}

}

