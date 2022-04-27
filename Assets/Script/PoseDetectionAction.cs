using Oculus.Interaction.PoseDetection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using UnityEngine.Events;

public class PoseDetectionAction : MonoBehaviour
{
    [SerializeField] private List<TextMeshProUGUI> displayPassword = new List<TextMeshProUGUI>();
    [SerializeField] private List<string> correctPassword = new List<string>();

    private int count = 0;
    private List<string> enteredPassword = new List<string>();

    public UnityEvent onCorectPassword;
    public UnityEvent onIncorrectPassword;
    public void AddPoseAsText(string text)
    {
        Debug.Log("Called");

        Debug.Log(text);

        if (count < displayPassword.Count)
        {
            displayPassword[count].text = text;
            enteredPassword.Add(text);
            count++;
        }
    }

    public void CheckPassword()
    {
        if (correctPassword.SequenceEqual(enteredPassword))
            onCorectPassword.Invoke();
        else
            onIncorrectPassword.Invoke();
    }

    public void ClearEnteredPassword()
    {
        count = 0;
        for(int i = 0; i < displayPassword.Count; i++)
            displayPassword[i].text = string.Empty;
        enteredPassword.Clear();
    }

}
