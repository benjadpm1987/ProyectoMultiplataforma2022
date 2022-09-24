using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDisparar : MonoBehaviour
{
    // Start is called before the first frame update
    //la bala
    public GameObject Bala_Original;
    public Transform Origen_Bala;

    public float Tiempo_Cadencia;
    float contador_tiempo;



    void Start()
    {
        Disparar();
    }

    // Update is called once per frame
    void Update()
    {

        if (contador_tiempo < Tiempo_Cadencia)
        {

            contador_tiempo += Time.deltaTime;

        }
        else {
            Disparar();
            contador_tiempo = 0;
        }


    }

    void Disparar() {
        // voy a crear una bala clon
        GameObject bala_clon = Instantiate(Bala_Original);
        //en que lugar se va a crear la bala
        bala_clon.transform.position = Origen_Bala.position;
        //tengo que impulsar la bala
        bala_clon.AddComponent<Rigidbody2D>();
        //quitarle la gravedad, que no caiga
        bala_clon.GetComponent<Rigidbody2D>().gravityScale = 0;
        //ahora si a impulsar la bala
        //definir la direccion
        float velocidad = 100.0f;
        Vector2 direccion = new Vector2(1,0);

        bala_clon.GetComponent<Rigidbody2D>().AddForce(direccion*velocidad);


    }
}
