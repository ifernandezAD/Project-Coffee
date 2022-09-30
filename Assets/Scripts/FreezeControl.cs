using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        StartCoroutine("ColdScene");
    }

    IEnumerator ColdScene()
    {
        myAnimator.SetTrigger("freezing");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(3);
    }
}


