using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidGenerator : MonoBehaviour {

    [SerializeField] private GameObject asteroidPrefab;
    
    

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 1000; i++)
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

            /*GameObject newAsteroid =
                Instantiate(
                asteroidPrefab,
                new Vector3(Random.Range(10000, 30000 * x), Random.Range(10000, 30000 * y), Random.Range(10000, 30000 * z)),
                Quaternion.Euler(Random.Range(0, 270), Random.Range(0, 270), Random.Range(0, 270))
                );
            newAsteroid.transform.localScale = new Vector3(Random.Range(1000, 5000), Random.Range(1000, 5000), Random.Range(1000, 5000));

            Rigidbody r = newAsteroid.GetComponent<Rigidbody>();
            r.mass = newAsteroid.transform.localScale.x * newAsteroid.transform.localScale.y * newAsteroid.transform.localScale.z;
            r.AddRelativeForce(new Vector3(Random.Range(0, 1000), Random.Range(0, 1000), Random.Range(0, 1000)) * r.mass);*/

            Vector3 tempPos = new Vector3(Random.Range(-10000, 10000), Random.Range(-10000, 10000), Random.Range(10000, 30000));
            Vector3 tempScale = new Vector3(Random.Range(500, 1000), Random.Range(500, 1000), Random.Range(500, 1000));
            float maxSide = tempScale.x;
            maxSide = maxSide < tempScale.y ? tempScale.y : maxSide;
            maxSide = maxSide < tempScale.z ? tempScale.z : maxSide;

            Collider[] colliders = Physics.OverlapSphere(tempPos, maxSide);

            if (colliders.Length == 0)
            {
                GameObject newAsteroid =
                    Instantiate(
                    asteroidPrefab,
                    tempPos,
                    Quaternion.Euler(Random.Range(0, 270), Random.Range(0, 270), Random.Range(0, 270))
                    );
                newAsteroid.transform.localScale = tempScale;

                Rigidbody r = newAsteroid.GetComponent<Rigidbody>();
                r.mass = newAsteroid.transform.localScale.x * newAsteroid.transform.localScale.y * newAsteroid.transform.localScale.z;
                r.angularVelocity = new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), Random.Range(-10f, 10f));
                r.velocity = new Vector3(Random.Range(-1000f, 1000f), Random.Range(-1000f, 1000f), Random.Range(-1000f, 1000f));
            }

        }
	}
	

	void Update () {

    }
}
