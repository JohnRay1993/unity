using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {

    [SerializeField] private GameObject firePrefab;
    [SerializeField] private Transform fireTransform;

    Rigidbody playerRigidbody;

	// Use this for initialization
	void Start () {
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        float ad = Input.GetAxisRaw("Horizontal") * 1;
        float ws = Input.GetAxisRaw("Vertical") * 1;
        float qe = Input.GetAxisRaw("QE") * -1;

        transform.Rotate(ws, ad, qe);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(transform.forward * 1000);
            //playerRigidbody.AddForce(transform.forward * 300);
        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            GameObject newFire = Instantiate(firePrefab, fireTransform);
            Rigidbody r = newFire.GetComponent<Rigidbody>();
            r.AddForce(transform.forward * 1000000);
            Destroy(newFire, 30);
        }
		
	}
}
