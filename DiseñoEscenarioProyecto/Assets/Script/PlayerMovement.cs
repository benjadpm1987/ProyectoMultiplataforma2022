using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public bool Cground = false;


    public int VIDA;
    public int DAMAGE;
    public GameObject Pantalla_GameOver;

    public AudioSource MusicaItem;
    public AudioSource MusicaItem2;

    int contador_buff = 0;
    public Text cuadro_texto;

    public Text texto_vidas;

         
    void Start()
    {
        texto_vidas.text = " " + VIDA;
    }

    void Update()
    {
       

        //Movimiento    
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

        //Salto
        if (Input.GetKeyDown(KeyCode.Space) && Cground == true)
        {
                //reproducir la musica
                GetComponent<AudioSource>().Play();

                GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
                Cground = false;
            
        }

    }
    private void  OnCollisionEnter2D(Collision2D other)
    {
        Cground = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
       

        if (collision.gameObject.tag == "buff")
        {
            MusicaItem.Play();

            contador_buff++;//contando de 1 en 1 // contador_buff+=1
            cuadro_texto.text =  " " + contador_buff;


            jumpHeight = jumpHeight + 5;
        }

        if (collision.gameObject.tag == "nerf")
        {
            MusicaItem2.Play();
            jumpHeight = jumpHeight - 5;
        }

        if (collision.gameObject.tag == "kill")
        {
            //reiniciando la escena
            //SceneManager.LoadScene(0);
            //Deberia aparecer la pantalla de game over, SI no tengo vidas
            VIDA = VIDA - DAMAGE;
            texto_vidas.text = " " + VIDA;

            if (VIDA <= 0)
            {
                texto_vidas.text = " " + 0;

                //Ejecutando las acciones del audio
                GameObject.Find("AdministradorSonidos").GetComponent<ReproductorMusica>().ReproducirMusicaFinal();


                Debug.Log("PERDISTE");
                Pantalla_GameOver.SetActive(true);

                GameObject.Find("Player").GetComponent<Rigidbody2D>().velocity = Vector2.zero;

                GameObject.Find("AdministradorEscenas").GetComponent<Administrador>().ReinicioXTiempo();

                GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;

                


            }

        }

        //destruir lo que choca con el personaje
        if(collision.gameObject.tag != "trampolin")
        Destroy(collision.gameObject);

        
    }

    /*private void OnCollisionExit2D(Collision2D collision)
    {
        Cground = false;
    }*/
}
