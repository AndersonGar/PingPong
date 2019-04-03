using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DetectorPuntos : MonoBehaviour {

    public Text txtPtsJugador, txtPtsEnemigo;
    int valPtsJugador=0, valPtsEnemigo=0;
    public CambiarEscena cambiadorEscena;
    public AudioSource audioPuntos;
    
	public void OnTriggerEnter2D(Collider2D pelotita)
    {
        if (gameObject.tag=="DetectorDer")
        {
            valPtsJugador++;
            SumarPuntos(txtPtsJugador,valPtsJugador);
        }
        else if (gameObject.tag == "DetectorIzq")
        {
            valPtsEnemigo++;
            SumarPuntos(txtPtsEnemigo, valPtsEnemigo);
        }
        pelotita.GetComponent<PelotaMuevete>().partidaEmpezada = false;
        DetectarGanador();
        audioPuntos.Play();
    }

    void SumarPuntos(Text label, int puntos)
    {
        label.text = puntos.ToString();
    }

    void DetectarGanador()
    {
        if (valPtsJugador==3)
        {
            cambiadorEscena.CambiarDeEscena("GanarEscena");
        }
        else if (valPtsEnemigo==3)
        {
            cambiadorEscena.CambiarDeEscena("PerderEscena");
        }
    }
}
