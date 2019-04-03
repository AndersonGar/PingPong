using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMov : MonoBehaviour {

    public Transform posPelotita;
    public float rapidez;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (posPelotita.GetComponent<PelotaMuevete>().partidaEmpezada)
        {
            if (posPelotita.position.y < transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y-rapidez, transform.position.z);
            }
            else if (posPelotita.position.y > transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + rapidez, transform.position.z);
            }
        }
	}
}
