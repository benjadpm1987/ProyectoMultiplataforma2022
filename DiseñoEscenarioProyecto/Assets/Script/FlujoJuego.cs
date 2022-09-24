using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlujoJuego : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PantallaPausa;
    bool pausa = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (pausa == false)
            {

                PantallaPausa.SetActive(true);

                AudioListener.volume = 0;

                pausa = true;
                Time.timeScale = 0;

            }
            else {
                PantallaPausa.SetActive(false);

                AudioListener.volume = 1;

                pausa = false;
                Time.timeScale = 1;
            }

        }



    }
}
