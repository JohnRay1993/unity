using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piu : MonoBehaviour {

    

    public GameObject blast_prefab;
    public Transform  spawn;

	// Use this for initialization
	//void Start () {
        //Instantiate(blast_prefab, spawn);
	//}

    public void Fire(int n)//(GameObject blast_prefab, Transform spawn)
    {
        //spawn = transform.parent;
        //spawn.position = new Vector3(0f, 0f, -5.5f);
        switch(n)
        {
            case 0:
                spawn.position = new Vector3(-2, spawn.position.y, spawn.position.z);
                break;
            case 1:
                spawn.position = new Vector3(0, spawn.position.y, spawn.position.z);
                break;
            case 2:
                spawn.position = new Vector3(2, spawn.position.y, spawn.position.z);
                break;
        }

        Destroy(Instantiate(blast_prefab, spawn), 1f);
    }
}
