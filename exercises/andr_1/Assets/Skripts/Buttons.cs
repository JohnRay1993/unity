using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {
    //public GameObject par;

    // Use this for initialization
    void Start () {
        //GameObject par = GetComponentInParent<GameObject>();
        /*if (par != null)
        {
            RectTransform ima = par.GetComponent<RectTransform>();
            if (ima != null)
            {
                RectTransform butt_size = GetComponent<RectTransform>();
                butt_size.sizeDelta = new Vector2((ima.rect.width / 3) - 5, butt_size.rect.height);
                //Debug.Log(butt_size.rect.width + " " + butt_size.rect.height + " " + ((ima.rect.width / 3) - 5));
            }
        }*/


        RectTransform[] buttons = GetComponentsInChildren<RectTransform>();
        if (buttons != null)
            for (int i = 0; i < buttons.Length; i++)
            {
            if (buttons[i].CompareTag("Button"))
                Debug.Log(buttons[i].rect.width + " " + buttons[i].rect.height);
            }
        else
            Debug.Log("null");
	}
	
	// Update is called once per frame
	void Update () {

    }
}
