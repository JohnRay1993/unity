using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject go;
    public Material mat;

    private float x = -8.85f, y = -4.95f;

    //8.85 4.95
    // Start is called before the first frame update
    void Start()
    {
        /*for (int xx = -495; xx < 300; xx++)
        {
            for (int yy = -495; yy < 300; yy++)
            {
                x = (float)xx / 100;
                y = (float)yy / 100;
                go.transform.position = new Vector3(x, y, 0);
                Instantiate(go);
            }
        }*/


        go.AddComponent<MeshFilter>();
        go.AddComponent<MeshRenderer>();
        go.GetComponent<Renderer>().material = mat;

        Mesh m = new Mesh();

        Vector3[] vertices = new Vector3[160]; // создаём массив вершин
        Vector2[] UVs = new Vector2[160]; // uv координат
        Vector4[] tangs = new Vector4[160]; // массив касательных

        int index = 0;
        int height = 4;
        int width = 4;

        for (int x = 0; x < height; x++)
        {
            for (int y = 0; y < width; y++)
            {
                index = (int)(y * width + x);

                vertices[index] = new Vector3(x, y, 0);
                UVs[index] = new Vector2(x, y);
            }
        }
        m.vertices = vertices;
        m.uv = UVs;

        index = 0;
        int[] triangles = new int[(height-1) * (width-1) * 6 * 10];
        for (int x = 0; x < height-1; x++)
        {
            for (int y = 0; y < width-1; y++)
            {
                //if (x != 1 || y != 1)
                {
                    triangles[index++] = (y * width) + x;
                    triangles[index++] = ((y + 1) * width) + x;
                    triangles[index++] = (y * width) + x + 1;

                    triangles[index++] = ((y + 1) * width) + x;
                    triangles[index++] = ((y + 1) * width) + x + 1;
                    triangles[index++] = (y * width) + x + 1;
                }
            }
        }
        m.triangles = triangles;

        m.RecalculateNormals();

        go.GetComponent<MeshFilter>().sharedMesh = m;

        //Mesh m = go.GetComponent<MeshFilter>().mesh;
        /*int[] triangles = m.triangles;
        triangles[0] = 0;
        triangles[1] = 0;
        triangles[2] = 0;
        m.triangles = triangles;*/



        /*for (int i = 0; i < m.triangles.Length; i++)
        {
            Debug.Log(i + " " + m.triangles[i]);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            //Mesh m = go.GetComponent<Mesh>();
            //Debug.Log(go.GetComponent<MeshFilter>().sharedMesh.vertices[0]);
            /*Debug.Log(go.GetComponent<MeshFilter>().sharedMesh.vertices[0]);
            go.GetComponent<MeshFilter>().sharedMesh.vertices[0] = new Vector3(4.5f, 0f, 4.5f);
            Debug.Log(go.GetComponent<MeshFilter>().sharedMesh.vertices[0]);*/
            //Mesh m = go.GetComponent<MeshFilter>().sharedMesh;
            /*for (int i = 0; i < m.vertices.Length; i++)
            {

                m.vertices[i] += new Vector3(0.1f, 0, 0.1f);

            }*/

            //m.vertices[0].Set(4f, 0f, 4f);

            //go.GetComponent<MeshFilter>().sharedMesh = m;

            //Debug.Log(m.vertices[0]);



            //go.GetComponent<MeshFilter>().sharedMesh.vertices[0].Set(4f, 0f, 4f);
            //go.GetComponent<MeshFilter>().sharedMesh.RecalculateBounds();
            //Debug.Log(go.GetComponent<MeshFilter>().sharedMesh.vertices[0]);

            //Mesh m = go.GetComponent<MeshFilter>().mesh;
            //Vector3[] vertices = m.vertices;
            /*for (int i = 0; i < m.vertices.Length; i++)
            {
                vertices[i] -= new Vector3(0.1f, 0, 0.1f);
            }*/
            /* Debug.Log(vertices[5]);
             Debug.Log(vertices[16]);
             Debug.Log(vertices[27]);*/
            /*vertices[0] += new Vector3(0f, 0.1f, 0f);
            vertices[1] += new Vector3(0f, 0.2f, 0f);
            vertices[2] += new Vector3(0f, 0.3f, 0f);
            vertices[3] += new Vector3(0f, 0.4f, 0f);
            vertices[4] += new Vector3(0f, 0.5f, 0f);
            vertices[5] += new Vector3(0f, 0.4f, 0f);
            vertices[6] += new Vector3(0f, 0.3f, 0f);
            vertices[7] += new Vector3(0f, 0.2f, 0f);
            vertices[8] += new Vector3(0f, 0.1f, 0f);*/
            //m.vertices = vertices;

            //m.RecalculateNormals();

            //m.RecalculateBounds();



            
        }
            












        //if (x < 8.9)
        //{
        //    /*if (y < 3)
        //    {
        //        y += 0.01f;
        //    }
        //    else
        //    {
        //        y = -4.95f;
        //        x += 0.01f;
        //    }*/
            //    for (int yy = -495; yy < 300; yy++)
            //    {
            //        y = (float)yy / 100;
            //        go.transform.position = new Vector3(x, y, 0);
            //        Instantiate(go);
            //    }
            //    x += 0.01f;
            //}
        }
    }
