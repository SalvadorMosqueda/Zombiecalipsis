using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisoTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("PLAYER")){
            Debug.Log("Entró el personaje");
        }
    }
}
