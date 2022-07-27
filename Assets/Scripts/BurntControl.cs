using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurntControl : MonoBehaviour
{
    private Animator myAnimator;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void OnEnable()
    {
        CoffeTemperature.burning += BurnEffect;
    }

    public void BurnEffect()
    {
        myAnimator.SetTrigger("Burnt");
    }
}
