using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeltCreate : MonoBehaviour {

    [SerializeField] private GameObject prefab;

	// Use this for initialization
	void Start () {
		for(int i = 1; i < 1000; i++)
        {
            GameObject n = Instantiate(prefab, new Vector3(Mathf.Sin(0.01f * i) * 700000, 0, Mathf.Cos(0.01f * i) * 700000), new Quaternion());
            n.SetActive(true);
        }
	}
}