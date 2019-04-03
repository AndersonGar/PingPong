using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaquetaMov : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 posCam = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x,Mathf.Clamp(posCam.y,-3.87f,3.87f),transform.position.z);
	}
}
