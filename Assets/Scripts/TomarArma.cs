using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomarArma : MonoBehaviour
{
    public GameObject ZonaAgarreDeArmaEnPlayer;
    public bool puedeAgarrarArma;

    public GameObject ArmaQueSeRecoge;
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

    private void OnTriggerEnter(Collider other) // ESTE METODO TAMBIEN LO HICE EN EL OTRO SCRIPT "ControlJgdr" PQ QUERIA INTENTAR DE NUEVO ESO DE LLAMAR A UNA FUNCION DE UN SCRIPT DESDE OTRO SCRIPT
    {
        //if (other.gameObject.CompareTag("Pistola")) // SI EL PLAYER TOCA LA PISTOLA...
        {
            //puedeAgarrarArma = true;
            ArmaQueSeRecoge = other.gameObject;

            ArmaQueSeRecoge.transform.rotation = Quaternion.Euler(0f, 180f, 0f);



        }
    }
}
