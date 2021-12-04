using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dissolveOnOff : MonoBehaviour
{
    public Renderer nikosFouma;
   

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            nikosFouma.material.SetInt("_Booleanonoff",1);
        }



    }
}
