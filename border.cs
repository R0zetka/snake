using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class border : MonoBehaviour {


    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("SnakeMain"))
        {
            Application.LoadLevel("main");
        }

    }
}
