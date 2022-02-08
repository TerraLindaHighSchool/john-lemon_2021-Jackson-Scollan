using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Spider : MonoBehaviour
{
    public NavMeshAgent spider;
    public Transform[] waypoints;
    public Transform player;

    int m_CurrentWaypointIndex;

    
   

    void Update()
    {
        spider.SetDestination(player.position);
    }

}