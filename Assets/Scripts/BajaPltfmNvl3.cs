using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BajaPltfmNvl3 : MonoBehaviour
{
    public Animator AnimBajarPltfmNvl3;
    void Start()
    {
        AnimBajarPltfmNvl3.enabled = false;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("CuboLlavePltfmNvl3"))
        {
            AnimBajarPltfmNvl3.enabled = true;
        }
    }
}
