using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproductorMusica : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource Reproductor;
    //el sonido que deberia pasar cuando muera
    public AudioClip Musica_Perdiste;
    void Start()
    {
        Reproductor = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReproducirMusicaFinal() {
        //1) Para la musica
        Reproductor.Stop();
        //2)Intercambiar el clip de audio
        Reproductor.clip = Musica_Perdiste;
        //3)Reproducir nueva musica
        Reproductor.Play();
    }
}
