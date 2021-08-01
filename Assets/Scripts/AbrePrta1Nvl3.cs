using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePrta1Nvl3 : MonoBehaviour
{
    public Animator AbrirPrta1Nvl3;
    public Animator Enem2;
    void Start()
    {
        AbrirPrta1Nvl3.enabled = false;
        Enem2.enabled = false;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AbrirPrta1Nvl3.enabled = true;
            Enem2.enabled = true;
        }
    }
}
