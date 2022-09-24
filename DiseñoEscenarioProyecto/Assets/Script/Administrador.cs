using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//le da las faculades para administrar escenas
using UnityEngine.SceneManagement;

public class Administrador : MonoBehaviour
{

    public void ReiniciarEscena()
    {
        //reiniciar a la escena 0
        SceneManager.LoadScene(0);

    }

    public void ReinicioXTiempo() 
    {
        Invoke("Reiniciar", 3.0f);
    
    }

    void Reiniciar() 
    {
        SceneManager.LoadScene(0);
    }
}
