using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tap : MonoBehaviour
{
    public GameObject prefab;
    public Camera cam;
    public float reload = 0.1f;

    private float dt = 0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dt <= 0f)
        {
            dt = reload;
            if (Input.GetMouseButton(0))
            {
                // Cast a ray from screen point
                Ray ray = cam.ScreenPointToRay(Input.mousePosition);
                // Save the info
                RaycastHit hit;
                // You successfully hi
                if (Physics.Raycast(ray, out hit))
                {
                    Vector3 pos = hit.point;
                    pos.y = 0;
                    pos.z = -6f;
                    Destroy(Instantiate(prefab, pos, prefab.transform.rotation), 1.5f);
                }
            }
        }
        dt -= Time.deltaTime;

    }
}



//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
//for (int i = 0; i < Input.touchCount; ++i)
//{
//    if (Input.GetTouch(i).phase == TouchPhase.Began)
//    {
//        Debug.Log(Input.GetTouch(0).position);
//    }
//}

//for (var touch : Touch in Input.touches)
//for (int i = 0; i < Input.touchCount; ++i)
//{
//    var touch = Input.GetTouch(i);
//    if (touch.phase == TouchPhase.Began)
//    {
//        // Construct a ray from the current touch coordinates
//        var ray = Camera.main.ScreenPointToRay(touch.position);
//        if (Physics.Raycast(ray))
//        {
//            Debug.Log(Input.GetTouch(0).position);
//            // Create a particle if hit
//            //Instantiate(particle, transform.position, transform.rotation);
//        }
//    }
//}



// Find the direction to move in
//Vector3 dir = hit.point;// - transform.position;

// Make it so that its only in x and y axis
//dir.y = 0; // No vertical movement

// Now move your character in world space 
//transform.Translate(dir * Time.DeltaTime * speed, Space.World);
//Debug.Log(dir);

// transform.Translate (dir * Time.DeltaTime * speed); // Try this if it doesn't work



//var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//Debug.Log(Input.mousePosition);
//Transform size = prefab.transform;
//size.position = new Vector3(Input.mousePosition.x, 0, -5.5f);
//var ray = cam.ScreenToWorldPoint(Input.mousePosition);
//if (Physics.Raycast(ray))
//{
//pos = new Vector3(pos.x, 0f, -5.5f);
//Destroy(Instantiate(prefab, pos, new Quaternion()), 1f);
//Debug.Log(ray + " " + Input.mousePosition);
//}