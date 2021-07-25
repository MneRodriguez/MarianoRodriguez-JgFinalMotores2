using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePrtaFnlNvl1 : MonoBehaviour
{
    public Animator AnimPrtaFnlNvl1;
    
    void Start()
    {
        //AnimPrtaFnlNvl1 = GetComponent<Animator>();

        AnimPrtaFnlNvl1.enabled = false;
        //AnimPrtaFnlNvl1.SetBool("SeAbrePrtaFinalNvl1", false);
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CuboLlavePrtaFnlNvl1")) // SI A LA ZONA QUE TRIGGEREA LA ANIM LA TOCA EL "CuboLlave"
        {
            AnimPrtaFnlNvl1.enabled = true; // LA PUERTA SE ABRE AL REPRODUCIRSE SU ANIMACION
            
        }
    }
}
