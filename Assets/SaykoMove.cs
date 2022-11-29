using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class SaykoMove : MonoBehaviour

{
    NavMeshAgent agent;
    public Transform target;
    
    
    public Button button;

    
    

    // Start is called before the first frame update
    void Start()
    {
        agent= GetComponent<NavMeshAgent>();

        
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void button_touch()
    {
        agent.SetDestination(target.position);
        

    }
}
