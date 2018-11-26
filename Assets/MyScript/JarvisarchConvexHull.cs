/*Please do support www.bitshiftprogrammer.com by joining the facebook page : fb.com/BitshiftProgrammer
Legal Stuff:
This code is free to use no restrictions but attribution would be appreciated.
Any damage caused either partly or completly due to usage of this stuff is not my responsibility*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JarvisMarchConvexHull : MonoBehaviour
{
    public Vector2[] points;
    [Range(0.05f, 1.5f)]
    public float size;
    public bool drawIt;
    private HashSet<Vector2> result;

    void Start()
    {
        result = new HashSet<Vector2>();
    }

    void Update()
    {
        result = new HashSet<Vector2>();
        int leftMostIndex = 0;
        for (int i = 1; i < points.Length; i++)
        {
            if (points[leftMostIndex].x > points[i].x)
                leftMostIndex = i;
        }
        result.Add(points[leftMostIndex]);
        List<Vector2> collinearPoints = new List<Vector2>();
        Vector2 current = points[leftMostIndex];
        while (true)
        {
            Vector2 nextTarget = points[0];
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i] == current)
                    continue;
                float x1, x2, y1, y2;
                x1 = current.x - nextTarget.x;
                x2 = current.x - points[i].x;

                y1 = current.y - nextTarget.y;
                y2 = current.y - points[i].y;

                float val = (y2 * x1) - (y1 * x2);
                if (val > 0)
                {
                    nextTarget = points[i];
                    collinearPoints = new List<Vector2>();
                }
                else if (val == 0)
                {
                    if (Vector2.Distance(current, nextTarget) < Vector2.Distance(current, points[i]))
                    {
                        collinearPoints.Add(nextTarget);
                        nextTarget = points[i];
                    }
                    else
                        collinearPoints.Add(points[i]);
                }
            }

            foreach (Vector2 t in collinearPoints)
                result.Add(t);
            if (nextTarget == points[leftMostIndex])
                break;
            result.Add(nextTarget);
            current = nextTarget;
        }
    }

    /*
    void OnDrawGizmos()
    {
        if (drawIt)
        {
            if (result != null)
            {
                List<Vector2> outter = new List<Vector2>();
                foreach (var item in result)
                    outter.Add(item);
                for (int i = 0; i < outter.Count - 1; i++)
                    Gizmos.DrawLine(outter[i].position, outter[i + 1].position);
                Gizmos.DrawLine(outter[0].position, outter[outter.Count - 1].position);
            }

            for (int i = 0; i < points.Length; i++)
            {
                Gizmos.color = Color.cyan;
                if (result != null)
                {
                    if (result.Contains(points[i]))
                        Gizmos.color = Color.yellow;
                }
                Gizmos.DrawSphere(points[i].position, size);
            }
        }
    }
    */
}