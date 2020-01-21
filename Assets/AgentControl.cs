using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentControl : MonoBehaviour
{
    public Camera cam;
    public Transform home;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
        agent.SetDestination(home.position);
    }

    // Update is called once per frame
    //  void Update()
    // {

    // }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //MOVE OuR Agent
                agent.SetDestination(hit.point);
            }
        }
    }

}
