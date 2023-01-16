using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    [SerializeField]
    private Transform[] waypoints;

    public int GetWaypointsLength()
    {
        return waypoints.Length;
    }

    public Vector3 GetWaypoint(int index)
    {
        if (index < waypoints.Length)
        {
            return waypoints[index].position;
        }

        return Vector3.zero;
    }

    private void OnDrawGizmos()
    {
        //Debug.DrawLine(waypoints[0].position, waypoints[1].position);
        //// Test en dessous strictement équivalent : on ajoute 1 à j.
        //int j = 0;
        //j = j + 1;
        //j += 1;
        //j++;

        for (int i = 0; i < waypoints.Length - 1; i++)
        {
            Debug.DrawLine(waypoints[i].position, waypoints[i + 1].position);
        }

    }
}
