using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePrta2Nvl3 : MonoBehaviour
{
    public Animator AbrirPrta2Nvl3;
    public Light LuzPrta2Nvl3;
    void Start()
    {
        AbrirPrta2Nvl3.enabled = false;

        GameObject LuzCambioDeColor = GameObject.FindWithTag("LuzRojoVerdePrta3");
        LuzPrta2Nvl3 = LuzCambioDeColor.GetComponent<Light>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CuboLlavePrta2Nvl3"))
        {
            AbrirPrta2Nvl3.enabled = true;
            LuzPrta2Nvl3.color = Color.green;
        }
    }
}
