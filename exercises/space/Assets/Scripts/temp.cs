﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temp : MonoBehaviour {

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(10, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
