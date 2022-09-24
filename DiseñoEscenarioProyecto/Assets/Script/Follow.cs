using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Player;
    public float offSetY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   


    void Update()
    {
        transform.position = new Vector3(transform.position.x, Player.transform.position.y+offSetY, transform.position.z);
    }


}
