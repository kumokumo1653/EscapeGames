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
    private GameObject gold;
    private GameObject jupyter;
    private GameObject sun;
    private GameObject upperAllow;
    private GameObject lowwerAllow;
    private LockBoxController controller;

    // Start is called before the first frame update
    void Start()
    {
        moon = this.transform.Find("moon").gameObject;
        fire = this.transform.Find("fire").gameObject;
        tree = this.transform.Find("tree").gameObject;
        water = this.transform.Find("water").gameObject;
        gold = this.transform.Find("gold").gameObject;
        jupyter = this.transform.Find("jupyter").gameObject;
        sun = this.transform.Find("sun").gameObject;

        upperAllow = this.transform.Find("upperAllow").gameObject;
        lowwerAllow = this.transform.Find("lowwerAllow").gameObject;
        upperAllow.GetComponent<PolygonCollider2D>().enabled = true;
        lowwerAllow.GetComponent<PolygonCollider2D>().enabled = true;

        InheritPlayer.Instance.GetComponent<ClickEventHandler>().clickEvent.AddListener(upper);
        InheritPlayer.Instance.GetComponent<ClickEventHandler>().clickEvent.AddListener(lowwer);

        controller = this.transform.parent.gameObject.GetComponent<LockBoxController>();

        updateDisplay();
    }

    public void updateDisplay() {
        moon.SetActive(false);
        fire.SetActive(false);
        tree.SetActive(false);
        water.SetActive(false);
        gold.SetActive(false);
        jupyter.SetActive(false);
        sun.SetActive(false);

        switch (display) {
            case 0:
                moon.SetActive(true);
                break;
            case 1:
                fire.SetActive(true);
                break;
            case 2:
                water.SetActive(true);
                break;
            case 3:
                tree.SetActive(true);
                break;
            case 4:
                gold.SetActive(true);
                break;
            case 5:
                jupyter.SetActive(true);
                break;
            case 6:
                sun.SetActive(true);
                break;
            case -1:
                upperAllow.GetComponent<PolygonCollider2D>().enabled = false;
                lowwerAllow.GetComponent<PolygonCollider2D>().enabled = false;
                break;
        }
    }

    public void upper(GameObject obj, Vector2 vec2) {
        if (obj == upperAllow) {
            if (display == 6) {
                display = 0;
            } else {
                display ++;
            }
            updateDisplay();
            controller.checkStatus();
        }
    }

    public void lowwer(GameObject obj, Vector2 vec2) {
        if (obj == lowwerAllow) {
            if (display == 0) {
                display = 6;
            } else {
                display --;
            }
            updateDisplay();
            controller.checkStatus();
        }
    }
}
