using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class KeyPadLogic : MonoBehaviour
{
    [SerializeField] private string correctPassword;
    [SerializeField] private TextMeshProUGUI keyPadDisplay;

    private string enteredPassword;

    public UnityEvent onCorrectPassword;
    public UnityEvent onIncorrectPassword;

    public void CheckPassword(string value)
    {
        enteredPassword += value;
        keyPadDisplay.text += value;

        if(enteredPassword.Length == correctPassword.Length && enteredPassword == correctPassword)
            onCorrectPassword.Invoke();
        else if(enteredPassword.Length == correctPassword.Length && enteredPassword != correctPassword)
            onIncorrectPassword.Invoke();
    }

    public void ResetEnteredPassword()
    {
        enteredPassword = string.Empty;
        keyPadDisplay.text = string.Empty;
    }
}
