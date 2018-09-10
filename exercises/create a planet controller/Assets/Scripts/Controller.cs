using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    [SerializeField] private float moveSpeed = 0.5f;
    [SerializeField] private float rotateSpeed = 10f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, Input.GetAxisRaw("Vertical") * moveSpeed);
        transform.Rotate(transform.up * Input.GetAxisRaw("Horizontal") * rotateSpeed);
	}
}
