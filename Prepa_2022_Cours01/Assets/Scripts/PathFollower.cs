using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField]
    private float distanceThreshold = 0.5f;

    [SerializeField]
    private float moveSpeed = 1;

    private Path path;


    int currentWaypointIndex = 0;

    public void SetPath(Path path)
    {
        this.path = path;
    }

    private void Update()
    {
        Vector3 destination = path.GetWaypoint(currentWaypointIndex);
        Vector3 movementDirection = (destination - transform.position).normalized;
        transform.position = transform.position + movementDirection * moveSpeed * Time.deltaTime;

        //float distanceToDestination = Vector3.Distance(transform.position, destination);
        //Debug.Log("distanceToDestination : " + distanceToDestination);

        if (Vector3.Distance(transform.position, destination) < distanceThreshold)
        {
            if (currentWaypointIndex < path.GetWaypointsLength() - 1)
            {
                currentWaypointIndex++;
            }
        }

    }
}
