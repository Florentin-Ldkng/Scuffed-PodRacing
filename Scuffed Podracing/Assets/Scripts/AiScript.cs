using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiScript : MonoBehaviour
{

    public GameObject CharacterDestination1;
    public GameObject CharacterDestination2;
    public GameObject CharacterDestination3;
    public GameObject CharacterDestination4;
    public GameObject CharacterDestination5;
    public GameObject CharacterDestination6;
    public GameObject CharacterDestination7;
    public GameObject CharacterDestination8;
    public PlayerController GetMovable;
    private bool _stared = false;
    NavMeshAgent theAgent;

    void Start()
    {
    }


    void Update()
    {
         MoveLocker();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Destination1")
        {
            theAgent.SetDestination(CharacterDestination2.transform.position);
        }
        if(other.tag == "Destination2")
        {
            theAgent.SetDestination(CharacterDestination3.transform.position);
        }
        if (other.tag == "Destination3")
        {
            theAgent.SetDestination(CharacterDestination4.transform.position);
        }
        if (other.tag == "Destination4")
        {
            theAgent.SetDestination(CharacterDestination5.transform.position);
        }
        if (other.tag == "Destination5")
        {
            theAgent.SetDestination(CharacterDestination6.transform.position);
        }
        if (other.tag == "Destination6")
        {
            theAgent.SetDestination(CharacterDestination7.transform.position);
        }
        if (other.tag == "Destination7")
        {
            theAgent.SetDestination(CharacterDestination8.transform.position);
        }
        if (other.tag == "Destination8")
        {
            theAgent.SetDestination(CharacterDestination1.transform.position);
        }
    }

    private void MoveLocker()
    {
        if (GetMovable.IsMoveable == true)
        {
            if (_stared == false)
            {
                theAgent = GetComponent<NavMeshAgent>();
                theAgent.SetDestination(CharacterDestination1.transform.position);
                _stared = true;
            }
            
        }
    }
}
