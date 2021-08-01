using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubirRetenEnem1 : MonoBehaviour
{
    public Animator CuboReten1;
    public Animator Enem1;
    void Start()
    {
       CuboReten1.enabled = false;
        Enem1.enabled = false;
    }

    
    void Update()
    {
        
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) // SI A LA ZONA QUE BORRA EL CUBO RETEN QUE DA PASO AL ENEM 1 LA TOCA EL PLAYER...
        {
            CuboReten1.enabled = true;
            Enem1.enabled = true;
        }
    }
}
