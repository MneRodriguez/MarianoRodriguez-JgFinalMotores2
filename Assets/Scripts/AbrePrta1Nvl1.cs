using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbrePrta1Nvl1 : MonoBehaviour
{
    public Animation AnimPrta1Nvl1;
    void Start()
    {
        AnimPrta1Nvl1 = GetComponent<Animation>();
        
        AnimPrta1Nvl1.enabled = false;
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            AnimPrta1Nvl1.Play();
        }
    }
}
