using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageColor : MonoBehaviour
{
    private Image image;

    void Start()
    {
        image = GetComponent<Image>();
    }

    public void SetColorRed()
    {
        image.color = Color.red;
    }

    public void SetColorGreen()
    {
        image.color = Color.green;
    }
}
