using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        gameObject.transform.localScale /= 2;
        float s = gameObject.transform.localScale.x;
        if (gameObject.transform.localScale.y > gameObject.transform.localScale.x)
            s = gameObject.transform.localScale.y;
        if (gameObject.transform.localScale.z > gameObject.transform.localScale.y)
            s = gameObject.transform.localScale.z;

        Transform t = gameObject.transform;
        t.position = gameObject.transform.position - Vector3.one * s * 2.5f;
        t.rotation = gameObject.transform.rotation;
        t.localScale = gameObject.transform.localScale;

        Instantiate(gameObject, t);






        //Destroy(gameObject);
    }
}
