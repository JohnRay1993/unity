using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_creator : MonoBehaviour
{
    public GameObject go;

    private Transform previous_object_transform;

    // Start is called before the first frame update
    void Start()
    {
        if (go != null)
        {
            for (int x = 0; x < 10; x++)
            {
                    go.transform.position = new Vector3(x, 0, 0);
                    go.transform.rotation = new Quaternion(0, 0, Random.Range(-1, 1), 1);
                    Instantiate(go, go.transform);
            }









            /*int max = 100;

            for (int x = 0; x < max; x++)
            {
                for (int z = 0; z < max; z++)
                {
                    go.transform.position = new Vector3(x, Random.Range(-1, 1), z);
                    go.transform.rotation = new Quaternion(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1), 1);
                    Instantiate(go, go.transform);
                }
            }*/
        }
    }
}
