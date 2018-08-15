using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour {

    [SerializeField] private GameObject asteroidPrefab;
    

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 10000; i++)
        {
            int s = i / 128;
            float x = 0, y = 0, z = 0;
            switch (s)
            {
                case 0:
                    {
                        x = -1;
                        y = -1;
                        z = 1;
                        break;
                    }
                case 1:
                    {
                        x = 1;
                        y = -1;
                        z = 1;
                        break;
                    }
                case 2:
                    {
                        x = -1;
                        y = -1;
                        z = -1;
                        break;
                    }
                case 3:
                    {
                        x = 1;
                        y = -1;
                        z = -1;
                        break;
                    }
                case 4:
                    {
                        x = -1;
                        y = 1;
                        z = 1;
                        break;
                    }
                case 5:
                    {
                        x = 1;
                        y = 1;
                        z = 1;
                        break;
                    }
                case 6:
                    {
                        x = -1;
                        y = 1;
                        z = -1;
                        break;
                    }
                case 7:
                    {
                        x = 1;
                        y = 1;
                        z = -1;
                        break;
                    }
            }

            GameObject newAsteroid =
                Instantiate(
                asteroidPrefab,
                new Vector3(Random.Range(1000, 30000 * x), Random.Range(1000, 30000 * y), Random.Range(1000, 30000 * z)),
                Quaternion.Euler(Random.Range(0, 270), Random.Range(0, 270), Random.Range(0, 270))
                );
            newAsteroid.transform.localScale = new Vector3(Random.Range(1000, 5000), Random.Range(1000, 5000), Random.Range(1000, 5000));

            Rigidbody r = newAsteroid.GetComponent<Rigidbody>();
            r.AddRelativeForce(new Vector3(Random.Range(0, 1000), Random.Range(0, 1000), Random.Range(0, 1000)) * Random.Range(0, 1000));
            r.mass = newAsteroid.transform.localScale.x * newAsteroid.transform.localScale.y * newAsteroid.transform.localScale.z;
        }
	}
	
	// Update is called once per frame
	void Update () {
        //if (i < 1000)
        //{
            

        //    /*newAsteroid.transform.position = new Vector3(Random.Range(100, 1000 * x), Random.Range(100, 1000 * y), Random.Range(100, 1000 * z));
        //    if (Mathf.Abs(newAsteroid.transform.position.x) < 10 || Mathf.Abs(newAsteroid.transform.position.y) < 10 || Mathf.Abs(newAsteroid.transform.position.z) < 10)
        //        newAsteroid.transform.position += new Vector3(10 * (newAsteroid.transform.position.x < 0 ? -1 : 1), 10 * (newAsteroid.transform.position.y < 0 ? -1 : 1), 10 * (newAsteroid.transform.position.z < 0 ? -1 : 1));
        //    newAsteroid.transform.rotation *= Quaternion.Euler(Random.Range(0, 270), Random.Range(0, 270), Random.Range(0, 270));*/

        //    //Rigidbody r = newAsteroid.GetComponent<Rigidbody>();
        //    //r.AddRelativeForce(new Vector3(Random.Range(0, 270), Random.Range(0, 270), Random.Range(0, 270)) * Random.Range(0, 100));


        //    i++;
        //}
    }
}
