using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAenemigos : MonoBehaviour
{
    public GameObject enem;
    public Rigidbody rbEnem;

    public NavMeshAgent navMeshAgent;
    public Transform target;

    void Start()
    {
        rbEnem = GetComponent<Rigidbody>();
        navMeshAgent = GetComponent<NavMeshAgent>();

        InvokeRepeating("SetDestino", 2f, 3f);
    }

    
    void Update()
    {
        
    }

    void SetDestino()
    {
        navMeshAgent.destination = target.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BalaJgdr")) // SI LOS ENEMS SON TOCADOS POR LAS BALAS DEL PLAYER, SE DESTRUYEN Y LE SUMAN PUNTOS
        {
            //ContadorDeScore.score += 2; FALTA HACERLO
            Destroy(gameObject);
        }
    }
}
