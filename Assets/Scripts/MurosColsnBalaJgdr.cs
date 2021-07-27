using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurosColsnBalaJgdr : MonoBehaviour
{
    public GameObject Muro;
    public Rigidbody rbMuro;
    void Start()
    {
        rbMuro = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // SI AL MURO LO TOCA LA BALA JUGADOR DEL PLAYER
    {
        if (other.gameObject.CompareTag("BalaJgdr"))
        {
            Destroy(gameObject);
        }
    }

    /*private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("BalaJgdr"))
        {
            Destroy(gameObject);
        }
    }*/
    
}
