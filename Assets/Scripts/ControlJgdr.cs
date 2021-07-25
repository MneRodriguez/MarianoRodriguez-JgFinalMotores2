using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class ControlJgdr : MonoBehaviour
{
    public float VelMax = 1.4f;
    public float gravedad = 6f;
    public float AlturaSalto = 1.9f;
    public float direccionMovto = 0;
        
    public Rigidbody rb;
    public BoxCollider mainCollider;

    public bool TocandoPiso = false;
    public bool EnElAire = false;
    

    public Light LuzNvl2_1, LuzNvl2_2, LuzNvl2_3;
    void Start()
    {
        
        
        rb = GetComponent<Rigidbody>();
        mainCollider = GetComponent<BoxCollider>();

        rb.collisionDetectionMode = CollisionDetectionMode.Continuous;        
        rb.constraints = RigidbodyConstraints.FreezePositionZ;

        rb.centerOfMass = Vector3.zero;
        rb.inertiaTensorRotation = Quaternion.identity;
        rb.constraints = RigidbodyConstraints.FreezeRotationX;  // CON ESTOS 3 QUISE PREVENIR NO SE INCLINE NI ROTE
        rb.constraints = RigidbodyConstraints.FreezeRotationY;
        rb.constraints = RigidbodyConstraints.FreezeRotationZ;



        GameObject LuzPrender1 = GameObject.FindWithTag("LuzAencender1");
        GameObject LuzPrender2 = GameObject.FindWithTag("LuzAencender2");
        GameObject LuzPrender3= GameObject.FindWithTag("LuzAencender3");

        LuzNvl2_1 = LuzPrender1.GetComponent<Light>();
        LuzNvl2_2 = LuzPrender2.GetComponent<Light>();
        LuzNvl2_1 = LuzPrender3.GetComponent<Light>();

        LuzNvl2_1.enabled = false;
        LuzNvl2_2.enabled = false;
        LuzNvl2_3.enabled = false;

    }
    void Update()
    {
        MoverJgdr();
        SaltarJgdr();              
                
    }

    public void MoverJgdr()
    {
        float x = Input.GetAxis("Horizontal");
        float movto = x * VelMax;
        rb.velocity = new Vector2(movto, rb.velocity.y); 
    }

    public void SaltarJgdr()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2(rb.velocity.x, AlturaSalto); // MECANICA DE SALTO, ARREGLAR LO DE QUE SALTA EN EL AIRE

            EnElAire = true;
        }
    }
    void FixedUpdate()
    {
        rb.AddForce(new Vector3(0, -gravedad * rb.mass, 0)); 

        TocandoPiso = false;
        EnElAire = true;

    }

    void OnCollisionStay()
    {
        TocandoPiso = true;
        EnElAire = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ZonaSwitchLucesNvl2"))
        {
            LuzNvl2_1.enabled = true;
            LuzNvl2_2.enabled = true;
            LuzNvl2_3.enabled = true;
        }

        if (other.gameObject.CompareTag("ObstaculoNvl2"))
        {
            SceneManager.LoadScene("MenuDerrtNvl2");
        }

        if (other.gameObject.CompareTag("ZonaWinNvl1"))
        {
            SceneManager.LoadScene("MenuVictoriaNvl1");
        }

        if (other.gameObject.CompareTag("ZonaWinNvl2"))
        {
            SceneManager.LoadScene("MenuVictoriaNvl2");
        }


    }

}
