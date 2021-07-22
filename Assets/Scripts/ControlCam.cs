using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCam : MonoBehaviour
{
    public GameObject Jugador;    
    public Vector3 offset;
    public float movtoCam = 0.5f;

    void Start()
    {
        offset = transform.position - Jugador.transform.position;
                
    }

    
    void Update()
    {
        Vector3 posDeCam = new Vector3(Jugador.transform.position.x, Jugador.transform.position.y, transform.position.z);
                
        // Suavizado del movimiento de la cámara
        transform.position = Vector3.SmoothDamp(transform.position, posDeCam, ref offset, movtoCam);
                
    }
}
