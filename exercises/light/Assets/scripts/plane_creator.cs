using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane_creator : MonoBehaviour
{
    public GameObject go;

    private Transform[,] previous_object_transform;
    private int x = 0, y = 0, z = 0;
    float z_angle;
    float x_len ;
    float y_pos;
    float last_y_pos = 0;

    // Start is called before the first frame update
    void Start()
    {
        previous_object_transform = new Transform[100, 100];
        //if (go != null)
        //{
        //    for (int x = 0; x < 10; x++)
        //    {
        //        double z_angle = Random.Range(-30, 30);
        //        go.transform.rotation = Quaternion.Euler(0, 0, (float)z_angle);
        //        double x_len = 1 / Mathf.Cos((float)z_angle);
        //        double y_pos = (x_len * Mathf.Sin((float)z_angle)) / 0.2;
        //        go.transform.position = new Vector3(x * 10, (float)y_pos, 0);
        //        go.transform.localScale = new Vector3((float)x_len, 1, 1);
        //        //new Quaternion(0, 0, Random.Range(-1, 1), 1);
        //        Instantiate(go, go.transform);
        //    }









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
        //}
    }

    void Update()
    {
        /*if (go != null)
        {
            if (x < 100 && z < 5)
            {



                z_angle = Random.Range(-5, 5);
                float z_angle_rad = z_angle * Mathf.PI / 180;
                x_len = 1 / Mathf.Cos(z_angle_rad);
                y_pos = (x_len * Mathf.Sin(z_angle_rad)) / 0.2f;

                //if (z < 100)
                //{
                //    z++;
                //}
                //else
                //{
                //    x++;
                //}
                //previous_object_transform
                
                go.transform.rotation = Quaternion.Euler(0, 0, z_angle);
                float prev_y = previous_object_transform[x == 0 ? 0 : x - 1, z] == null ? 0 : (previous_object_transform[x == 0 ? 0 : x - 1, z].position.y);
                go.transform.position = new Vector3(x * 10, y_pos + last_y_pos, z * 10);
                go.transform.localScale = new Vector3(x_len, 1, 1);

                Instantiate(go);//, go.transform);
                last_y_pos += y_pos * 2;
                previous_object_transform[x, z] = go.transform;


                if (x == 99)
                {
                    x = 0;*
                    z++;
                    last_y_pos = 0;
                }
                else
                    x++;
            }
        }*/
    }
}
