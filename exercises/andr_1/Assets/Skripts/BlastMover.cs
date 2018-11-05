using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlastMover : MonoBehaviour {

    public float speed = 10f;
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0f, 0f, 1f) * speed * Time.deltaTime;		
	}
}
