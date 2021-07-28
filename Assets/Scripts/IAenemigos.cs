using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAenemigos : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BalaJgdr")) // SI LOS ENEMS SON TOCADOS POR LAS BALAS DEL PLAYER, SE DESTRUYEN Y LE SUMAN PUNTOS
        {
            //ContadorDeScore.score += 2; FALTA HACERLO
            Destroy(gameObject);
        }
    }
}
