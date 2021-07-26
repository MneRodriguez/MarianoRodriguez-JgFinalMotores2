using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoDelJgdr : MonoBehaviour
{
    public Transform ZonaSpawnDelDisparoJgdr;
    public GameObject balaPrefab;

    public float VelDesplzBalaJgdr = 20f;
    public float duracionBala = 2.5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        //if (TomarArma) // SI EL PLAYER RECOGE EL ARMA
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Disparar();
            }
        }
        
        
    }

    void Disparar()
    {
        GameObject balaJgdr = Instantiate(balaPrefab, ZonaSpawnDelDisparoJgdr.position, ZonaSpawnDelDisparoJgdr.rotation);
        Rigidbody rbala = balaJgdr.GetComponent<Rigidbody>();
        rbala.AddForce(ZonaSpawnDelDisparoJgdr.transform.right * VelDesplzBalaJgdr, ForceMode.Impulse);

        Destroy(balaJgdr, duracionBala);
    }
}
