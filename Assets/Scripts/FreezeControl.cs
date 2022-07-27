using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeControl : MonoBehaviour
{

    private Animator myAnimator;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    public void OnEnable()
    {
        CoffeTemperature.freezing += FreezeEffect;
    }

    public void FreezeEffect()
    {
        myAnimator.SetTrigger("freezing");
    }

}
