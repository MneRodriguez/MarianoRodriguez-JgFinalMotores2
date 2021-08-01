using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirRetenEnem2 : MonoBehaviour
{
    public Animator CuboReten2, CuboReten3;
    public Animator Enem3, Enem4;
    void Start()
    {
        CuboReten2.enabled = false;
        CuboReten3.enabled = false;

        Enem3.enabled = false;
        Enem4.enabled = false;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // SI A LA ZONA QUE BORRA EL CUBO RETEN QUE DA PASO AL ENEM 2 LA TOCA EL PLAYER...
        {
            CuboReten2.enabled = true;
            CuboReten3.enabled = true;

            Enem3.enabled = true;
            Enem4.enabled = true;
        }
    }
}
