using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreJaula : MonoBehaviour
{
    public GameObject PuertaDeJaula;
    void Start()
    {
        GameObject PuertaJaulaCuboLlave = GameObject.FindWithTag("PuertaJaulaCuboLlave");
        PuertaDeJaula = PuertaJaulaCuboLlave;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // SI A LA ZONA QUE ABRE LA PUERTA DE LA JAULA LA TOCA EL PLAYER
        {
            Destroy(PuertaDeJaula);
        }
    }
}
