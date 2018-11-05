using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageWait : MonoBehaviour {



    private Coroutine m_cor;
    private Image image;
    private bool end = false;

	// Use this for initialization
	void Start () {
        image = GetComponent<Image>();

        image.fillClockwise = false;
        image.fillAmount = 1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
        {
            //if (m_cor == null)
            //m_cor = StartCoroutine(Routine());
            StartCoroutine(Routine());
        }
	}

    private IEnumerator Routine()
    {
        float c = 100;
        while(true)
        //for (int i = 0; i < 100; i++)
        {
            while (image.fillAmount > 0)
            {
                image.fillAmount -= Time.deltaTime;
                yield return null;
            }
            //if (!image.fillClockwise && image.fillAmount < 0.1f)
                image.fillClockwise = true;
            while (image.fillAmount < 1)
            {
                image.fillAmount += Time.deltaTime;
                yield return null;
            }
            //if (image.fillClockwise && image.fillAmount > 1)
            //{
                image.fillClockwise = false;
                //end = true;
            //}
            //c -= Time.deltaTime;
        }

        //yield return null;
    }
}
