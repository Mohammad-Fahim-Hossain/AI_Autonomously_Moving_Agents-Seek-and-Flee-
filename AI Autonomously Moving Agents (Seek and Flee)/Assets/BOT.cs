using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BOT : MonoBehaviour
{
    public GameObject Target;
    NavMeshAgent Agent;
    
    // Start is called before the first frame update
    void Start()
    {
        Agent = this.GetComponent<NavMeshAgent>(); 
    }

    void Seek(Vector3 Location) {

        Agent.SetDestination(Location);

    }


    // Update is called once per frame
    void Update()
    {
        Seek(Target.transform.position);
    }
}
