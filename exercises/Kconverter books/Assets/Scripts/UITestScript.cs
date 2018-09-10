using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UITestScript : MonoBehaviour {

    [SerializeField] private GameObject UIObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject == UIObj)
        //{
        //    DoUISomething();
        //}
        //else if (Input.GetMouseButtonDown(0))
        //{
        //    Shot();
        //}
	}
}
