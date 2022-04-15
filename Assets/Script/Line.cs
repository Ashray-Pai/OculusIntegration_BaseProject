using System.Linq;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

// Representation of a line, consisting of many points and drawn by a line renderer.
[RequireComponent(typeof(LineRenderer))]
public class Line : MonoBehaviour
{
    // get the line renderer component
    private LineRenderer lineRenderer = null;
    // store the points that make up the line in a list of Vector3.
    private List<Vector3> points = new List<Vector3>();
    private float drawingThreshold = 0.001f;


    private void Awake()
    {
        this.lineRenderer = GetComponent<LineRenderer>();
    }

    // Update the line with a new position.
    public void UpdateLine(Vector3 newPoistion)
    {
        if(this.GetDistance(newPoistion))
        {
            this.points.Add(newPoistion);
            this.lineRenderer.positionCount = this.points.Count;
            this.lineRenderer.SetPosition(this.points.Count - 1, newPoistion);
        }
    }

    private bool GetDistance(Vector3 position)
    {
        return this.points.Count == 0 ? true : Vector3.Distance(this.points.Last(), position) > this.drawingThreshold;
    }

}
