using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorrarPowerUp : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ContadorDeScore.valorScore += 1;
            Destroy(gameObject);
        }
    }
}
