using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaMuevete : MonoBehaviour {

    public Transform posRaqueta;
    float difPos;
    public bool partidaEmpezada = false;
    public Rigidbody2D velBall;
    public AudioSource audioGolpe;
	void Start () {
        difPos = transform.position.x - posRaqueta.position.x;
	}

    // Update is called once per frame
    void Update() {
        if (!partidaEmpezada)
        {
            transform.position = new Vector3(posRaqueta.position.x + difPos, posRaqueta.position.y, transform.position.z);
            if (Input.GetMouseButtonDown(0))
            {
                velBall.velocity = new Vector2(5,10);
                partidaEmpezada = true;
            }
        }
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        audioGolpe.Play();
    }
}
