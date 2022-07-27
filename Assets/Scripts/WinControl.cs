using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinControl : MonoBehaviour
{
    private Animator myAnimator;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void OnEnable()
    {
        CoffeTemperature.winning += WinEffect;
    }

    public void WinEffect()
    {
        myAnimator.SetTrigger("win");
    }
}
