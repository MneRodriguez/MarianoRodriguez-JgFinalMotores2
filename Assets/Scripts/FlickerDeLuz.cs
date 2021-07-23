using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerDeLuz : MonoBehaviour
{
    public bool estaFallando = false;
    public float VelDeFlicker = 100.01f;
    private float randomizer = 0;

    public Light LuzFallada1;
    void Start()
    {
        GameObject LuzRota1 = GameObject.FindWithTag("LuzFallada1");
        LuzFallada1 = LuzRota1.GetComponent<Light>();
    }

    
    void Update()
    {
       if (estaFallando == false)
        {
            StartCoroutine(HacerFlicker());
        }
    }

    public IEnumerator HacerFlicker() {

        estaFallando = true;
        LuzFallada1.enabled = false;
        randomizer = Random.Range(0.2f, 0.1f);
        yield return new WaitForSeconds(VelDeFlicker);
        LuzFallada1.enabled = true;
        randomizer = Random.Range(0.2f, 0.1f);
        yield return new WaitForSeconds(VelDeFlicker);
        estaFallando = false;

    }
}
