using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccionesCirculo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
no xd
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy(collision.gameObject);
        collision.transform.position = new Vector3(0, 4, 0);
	Destroy(collision.gameObject);
        Debug.Log("ESTA CHOCANDO");
    }
}
