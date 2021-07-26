using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarArma : MonoBehaviour
{
    public GameObject ZonaAgarreDeArmaEnPlayer;
    bool puedeAgarrarArma;

    GameObject ArmaQueSeRecoge;
    //bool tieneElArma;

    void Start()
    {
        puedeAgarrarArma = false;
        //tieneElArma = false;
    }

    
    void Update()
    {
        if (puedeAgarrarArma == true)
        {
            ArmaQueSeRecoge.GetComponent<Rigidbody>().isKinematic = true;
            ArmaQueSeRecoge.transform.position = ZonaAgarreDeArmaEnPlayer.transform.position; // ESTE SERIA EL PRIMER EMPTY CHILD DEL PLAYER
            ArmaQueSeRecoge.transform.parent = ZonaAgarreDeArmaEnPlayer.transform; // CONVIERTE A LA PISTOLA EN CHILD DE LA ZONA DE AGARRE DEL PLAYER
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pistola")) // SI EL PLAYER TOCA LA PISTOLA...
        {
            puedeAgarrarArma = true;
            ArmaQueSeRecoge = other.gameObject;
        }
    }
}
