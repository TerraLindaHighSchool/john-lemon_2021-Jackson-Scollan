using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Skeleton : MonoBehaviour 
{

    public NavMeshAgent enemy;
    public Transform player;
    public Transform[] moveWaypoint;
    int m_CurrentWaypointIndex;
    public int follow = 9;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.transform.position, enemy.transform.position);
        if (distance < follow)
        {
            enemy.SetDestination(player.position);
        }
        else
        {
            enemy.SetDestination(moveWaypoint[m_CurrentWaypointIndex].position);
        }
    }

 
}
