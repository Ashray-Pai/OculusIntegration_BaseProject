using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System.Linq;

public class SliderUnlockLogic : MonoBehaviour
{
    [SerializeField] private List<int> correctPassword = new List<int>();
    [SerializeField] private List<Slider> sliders = new List<Slider>();

    private List<int> enteredPassword = new List<int>();

    public UnityEvent onCorrectPassword;
    public UnityEvent onIncorrectPassword;

    public void CheckPassword()
    {
        for (int i = 0; i < sliders.Count; i++)
            enteredPassword.Add((int)sliders[i].value);
        if(Enumerable.SequenceEqual(enteredPassword, correctPassword))
            onCorrectPassword.Invoke();
        else
            onIncorrectPassword.Invoke();
    }

    public void RestEnteredPassword()
    {
        enteredPassword.Clear();
        for (int i = 0; i < sliders.Count; i++)
            sliders[i].value = 0;
    }

}
