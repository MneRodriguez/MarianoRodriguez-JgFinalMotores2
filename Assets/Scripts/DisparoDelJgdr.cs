using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoDelJgdr : MonoBehaviour
{
    public Transform ZonaSpawnDelDisparoJgdr;
    public GameObject balaPrefab;

    public float VelDesplzBalaJgdr = 10f;
    public float duracionBala = 0.9f;

    public bool habilitarDisparo = false;

    public GameObject MuroParaDestruir1, MuroParaDestruir2, MuroParaDestruir3;
    void Start()
    {
        GameObject MuroAdestruir1 = GameObject.FindWithTag("MuroDestrct1");
        GameObject MuroAdestruir2 = GameObject.FindWithTag("MuroDestrct2");
        GameObject MuroAdestruir3 = GameObject.FindWithTag("MuroDestrct3");

        MuroParaDestruir1 = MuroAdestruir1;
        MuroParaDestruir2 = MuroAdestruir2;
        MuroParaDestruir3 = MuroAdestruir3;
    }

    
    void Update()
    {
        if (habilitarDisparo) // SI EL PLAYER RECOGE EL ARMA
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Disparar();
            }
        }
        
        
    }

    public void Disparar()
    {
        GameObject balaJgdr = Instantiate(balaPrefab, ZonaSpawnDelDisparoJgdr.position, ZonaSpawnDelDisparoJgdr.rotation);
        Rigidbody rbala = balaJgdr.GetComponent<Rigidbody>();
        rbala.AddForce(ZonaSpawnDelDisparoJgdr.transform.right * VelDesplzBalaJgdr, ForceMode.Impulse);

        Destroy(balaJgdr, duracionBala);
    }

    private void OnCollisionEnter(Collision collision)        // CON ESTO QUERIA HACER QUE LA BALA SE BORRE AL HACER CONTACTO, 
                                                                // PERO LUEGO RECORDE QUE LA LINEA DE ARRIBA ES LA QUE SETEA EL TIEMPO EN EL QUE DESAPARECE
    {
        if (collision.gameObject.CompareTag("MuroDestrct1"))
        {
            Destroy(MuroParaDestruir1);
        }

        if (collision.gameObject.CompareTag("MuroDestrct2"))
        {
            Destroy(MuroParaDestruir2);
        }

        if (collision.gameObject.CompareTag("MuroDestrct3"))
        {
            Destroy(MuroParaDestruir3);
        }
    }
}
