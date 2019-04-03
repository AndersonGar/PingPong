using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour {
    
	public void CambiarDeEscena(string nombreEscena)
    {      
        SceneManager.LoadScene(nombreEscena);            
    }
}
