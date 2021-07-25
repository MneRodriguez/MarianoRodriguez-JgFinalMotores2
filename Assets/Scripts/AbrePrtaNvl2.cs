using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePrtaNvl2 : MonoBehaviour
{
    //public Animator AnimPrtaNvl2;
    public Light LuzNvl2_4;

    void Start()
    {
        GameObject LuzCambiaColor = GameObject.FindWithTag("LuzRojoVerdePrta"); 
        LuzNvl2_4 = LuzCambiaColor.GetComponent<Light>();

        //AnimPrtaNvl2.enabled = false;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CuboLlavePrtaNvl2")) // SI A LA ZONA QUE TRIGGEREA LA ANIM LA TOCA EL "CuboLlave"
        {
            //AnimPrtaNvl2.enabled = true;
            LuzNvl2_4.color = Color.green;
        }
    }
}
