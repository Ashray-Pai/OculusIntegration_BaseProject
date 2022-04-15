using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyDetection : MonoBehaviour
{
    [SerializeField] private float minScaleValue;
    [SerializeField] private float maxScaleValue;
    [SerializeField] private Vector3 keyPosition;
    [SerializeField] private Quaternion keyRotation;

    public UnityEvent unlock;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Key")
        {
            if(other.transform.localScale.x >= minScaleValue && other.transform.localScale.x <= maxScaleValue)
            {
                unlock.Invoke();
                other.transform.parent = this.transform ;
                other.transform.localPosition = keyPosition;
                other.transform.localRotation = keyRotation;
            }
        }
    }
}
