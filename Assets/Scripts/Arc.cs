using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arc : MonoBehaviour
{
    public float radius;
    public float angle;
    public int segments;
    
    
    void Start()
    {
        LineRenderer lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segments + 1;

        float angleInRadians = Mathf.Deg2Rad * angle;
        float segmentAngle = angleInRadians / segments;

        for (int i = 0; i <= segments; i++)
        {
            float x = Mathf.Sin(segmentAngle * i) * radius;
            float y = Mathf.Cos(segmentAngle * i) * radius;

            lineRenderer.SetPosition(i, new Vector3(x, y, 0f));
        }
    }
}
