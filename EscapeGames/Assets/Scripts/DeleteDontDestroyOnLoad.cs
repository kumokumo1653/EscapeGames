using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeleteDontDestroyOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.MoveGameObjectToScene(InheritPlayer.Instance, SceneManager.GetActiveScene());
        SceneManager.MoveGameObjectToScene(InheritTextArea.Instance, SceneManager.GetActiveScene());
        SceneManager.MoveGameObjectToScene(InheritItemArea.Instance, SceneManager.GetActiveScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
