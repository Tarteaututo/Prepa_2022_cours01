using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WorldLimits : MonoBehaviour
{
    [SerializeField]
    private float xLimit = 50f;

    [SerializeField]
    private float zLimit = 50f;

    [SerializeField]
    private Color lineColor = Color.black;

    public Vector3 Clamp(Vector3 position)
    {
        if (position.z > transform.position.z + zLimit)
        {
            position.z = transform.position.z + zLimit;
        }

        return position;
    }

    private void OnDrawGizmos()
    {
        Vector3 upLeft = transform.position + new Vector3(-xLimit, 0, zLimit);
        Vector3 upRight = transform.position + new Vector3(xLimit, 0, zLimit);
        Vector3 downLeft = transform.position + new Vector3(-xLimit, 0, -zLimit);
        Vector3 downRight = transform.position + new Vector3(xLimit, 0, -zLimit);

        Debug.DrawLine(upLeft, upRight, lineColor);
        Debug.DrawLine(upRight, downRight, lineColor);
        Debug.DrawLine(downRight, downLeft, lineColor);
        Debug.DrawLine(downLeft, upLeft, lineColor);
    }
}
