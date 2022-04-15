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

    private void Start()
    {
        this.lineRenderer = GetComponent<LineRenderer>();
        Debug.Log("started line");

    }

    // Adds a point at a new position and syncs the line renderer size.
    public void SetPoint(Vector3 newPosition)
    {
        this.points.Add(newPosition);

        this.lineRenderer.positionCount = this.points.Count;
        this.lineRenderer.SetPosition(this.points.Count - 1, newPosition);
    }

    // Update the line with a new position.
    public void UpdateLine(Vector3 position)
    {
        if(points.Count ==0)
            this.SetPoint(position);
        else if (Vector3.Distance(this.points.Last(), position) > 0.001f)
            this.SetPoint(position);
    }
}
