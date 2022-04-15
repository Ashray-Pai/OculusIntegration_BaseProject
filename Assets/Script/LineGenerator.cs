using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    [SerializeField] private GameObject linePrefab;
    [SerializeField] private Transform paper;
    [SerializeField] private Transform tipPosition;

    private Line activeLine = null;
    private bool isTouching = false;
    private float cutoutOffset = 0.001f;

    void Update()
    {
        if(this.isTouching && this.activeLine == null)
        {
            GameObject newLine = Instantiate(this.linePrefab);
            this.activeLine = newLine.GetComponent<Line>();
        }

        if(!this.isTouching)
        {
            this.activeLine = null;
        }

        if(this.activeLine != null)
        {
            Vector3 newPos = new Vector3(this.tipPosition.position.x, this.paper.position.y + this.cutoutOffset, this.tipPosition.position.z);
            this.activeLine.UpdateLine(newPos);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if( other.tag == "Paper")
            this.isTouching = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Paper")
            this.isTouching = false;
    }

}
