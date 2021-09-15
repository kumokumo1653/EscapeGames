using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    public Button GoToTitle;
    void Start()
    {
        GoToTitle.onClick.AddListener(LoadTitle);
    }

    void LoadTitle() {
        SceneManager.LoadScene("Title");
    }
}
