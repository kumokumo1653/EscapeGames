using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBox : MonoBehaviour
{
    public int display;
    private GameObject moon;
    private GameObject fire;
    private GameObject tree;
    private GameObject water;
    private GameObject upperAllow;
    private GameObject lowwerAllow;

    // Start is called before the first frame update
    void Start()
    {
        moon = this.transform.Find("moon").gameObject;
        fire = this.transform.Find("fire").gameObject;
        tree = this.transform.Find("tree").gameObject;
        water = this.transform.Find("water").gameObject;

        upperAllow = this.transform.Find("upperAllow").gameObject;
        lowwerAllow = this.transform.Find("lowwerAllow").gameObject;

        InheritPlayer.Instance.GetComponent<ClickEventHandler>().clickEvent.AddListener(upper);
        InheritPlayer.Instance.GetComponent<ClickEventHandler>().clickEvent.AddListener(lowwer);

        updateDisplay();
    }

    private void updateDisplay() {
        moon.SetActive(false);
        fire.SetActive(false);
        tree.SetActive(false);
        water.SetActive(false);

        switch (display) {
            case 0:
                moon.SetActive(true);
                break;
            case 1:
                fire.SetActive(true);
                break;
            case 2:
                tree.SetActive(true);
                break;
            case 3:
                water.SetActive(true);
                break;
        }
    }

    public void upper(GameObject obj, Vector2 vec2) {
        if (obj == upperAllow) {
            if (display == 3) {
                display = 0;
            } else {
                display ++;
            }
        }
        updateDisplay();
    }

    public void lowwer(GameObject obj, Vector2 vec2) {
        if (obj == lowwerAllow) {
            if (display == 0) {
                display = 3;
            } else {
                display --;
            }
        }
    }
}
