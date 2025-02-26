using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Transform[] Waypoints;
    public float[] SegmentDistances;

    // Start is called before the first frame update
    void Start()
    {
        SegmentDistances = new float[Waypoints.Length];
        SegmentDistances[0] = 0;
        for (int i = 1; i < SegmentDistances.Length; i++)
        {
            SegmentDistances[i] = Vector3.Distance(Waypoints[i-1].position, Waypoints[i].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetDistanceRemaining(Vector3 position, int nextWaypoint)
    {
        float distanceTotal = Vector3.Distance(position, Waypoints[nextWaypoint].position);
        for (int i = nextWaypoint + 1; i < SegmentDistances.Length; i++)
        {
            distanceTotal += SegmentDistances[i];
        }

        return (distanceTotal);
    }
}
