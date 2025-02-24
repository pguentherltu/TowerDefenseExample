using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform[] Waypoints;
    public int currentDestination;
    public float Speed = 2;
    public float WaypointAcceptableError = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        currentDestination = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[currentDestination].position, Speed * Time.deltaTime);
        transform.LookAt(Waypoints[currentDestination].position);

        if (Vector3.Distance(transform.position, Waypoints[currentDestination].position) <= WaypointAcceptableError)
        {
            currentDestination++;
        }

    }
}
