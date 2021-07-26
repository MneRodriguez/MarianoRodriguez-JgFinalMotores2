using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurosColsnBalaJgdr : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("BalaJgdr"))  // SI AL MURO LO TOCA LA BALA JUGADOR DEL PLAYER
        {
            Destroy(other.gameObject);        
        } 
    }
}
