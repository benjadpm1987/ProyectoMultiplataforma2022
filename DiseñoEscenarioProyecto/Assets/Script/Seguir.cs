﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Objetivo_Seguir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Objetivo_Seguir != null) {

            transform.position = Objetivo_Seguir.position;

        }



    }
}
