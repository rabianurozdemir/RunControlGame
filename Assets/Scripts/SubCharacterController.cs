using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class SubCharacterController : MonoBehaviour
{
    GameObject _target;
    NavMeshAgent _navMeshAgent;

    void Start()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().destinationPoint;

    }

    void LateUpdate()
    {
        _navMeshAgent.SetDestination(_target.transform.position); // It is necessary to give position in AI

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NeedleBox"))
        {
            GameObject.FindWithTag("GameManager").GetComponent<GameManager>().currentCharacterCount--;
            gameObject.SetActive(false);
        }
    }
}
