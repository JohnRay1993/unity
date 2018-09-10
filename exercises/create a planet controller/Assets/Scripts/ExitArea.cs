using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitArea : MonoBehaviour {

    [SerializeField] private Transform playerTransform;

    void OnTriggerExit(Collider other)
    {
        playerTransform.position = new Vector3(playerTransform.position.x * -1, playerTransform.position.y, playerTransform.position.z * -1);
    }
}
