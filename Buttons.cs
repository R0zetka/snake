using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {

  

    void OnMouseUpAsButton()
    {
        switch(gameObject.name){
            case"exit":
                Application.Quit();
                break;
            case"play":
                Application.LoadLevel("Snake");
                break;
        }
    }
}
