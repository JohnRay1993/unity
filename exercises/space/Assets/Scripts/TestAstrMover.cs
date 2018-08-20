using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAstrMover : MonoBehaviour
{
    public Rigidbody tempRB;

    private Rigidbody rb;

    private float m = 0;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (tempRB == null)
        {
            //rb.AddForce(transform.forward * 100000);
        }
        else
        {
            rb.velocity = tempRB.velocity;
            rb.rotation = tempRB.rotation;
            rb.angularVelocity = tempRB.angularVelocity;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collider)
    {
        m = transform.localScale.x;
        m = m < transform.localScale.y ? transform.localScale.y : m;
        m = m < transform.localScale.z ? transform.localScale.z : m;

        if (m > 1 && rb.mass / 2 < collider.rigidbody.mass)
        {
            
            transform.position -= transform.right * m/2;
            transform.localScale = transform.localScale / 2f;
            rb.mass = transform.localScale.x * transform.localScale.y * transform.localScale.z;


            GameObject second = Instantiate(gameObject);
            second.transform.position += transform.right * m/2 * 2;
            Rigidbody rb2 = second.GetComponent<Rigidbody>();

            second.GetComponent<TestAstrMover>().tempRB = rb;
        }
    }


}