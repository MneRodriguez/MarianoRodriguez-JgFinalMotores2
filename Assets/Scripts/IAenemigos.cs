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

    private void OnTriggerEnter(Collider other) // SI LOS ENEMS SON TOCADOS POR LAS BALAS DEL PLAYER, SE DESTRUYEN Y LE SUMAN PUNTOS
    {
        if (other.gameObject.CompareTag("BalaJgdr"))
        {
            ContadorDeScore.valorScore += 2;
            Destroy(gameObject);
        }
    }
}
