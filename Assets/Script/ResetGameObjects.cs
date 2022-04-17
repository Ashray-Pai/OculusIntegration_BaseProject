using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameObjects : MonoBehaviour
{
    [SerializeField] private List<GameObject> physicsObjects;

    private List<Vector3> originalPosition = new List<Vector3>();

    private void Awake()
    {
        for(int i = 0; i < physicsObjects.Count; i++)
            originalPosition.Add(physicsObjects[i].transform.localPosition);
    }

    public void ResetPhysicsObjects()
    {
        for(int i = 0; i < physicsObjects.Count; i++)
        {
            physicsObjects[i].GetComponent<Rigidbody>().velocity = Vector3.zero;
            physicsObjects[i].GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            physicsObjects[i].transform.localPosition = originalPosition[i];
        }
    }
}
