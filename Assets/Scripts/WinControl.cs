using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        StartCoroutine("PerfectScene");
    }

    IEnumerator PerfectScene()
    {
        myAnimator.SetTrigger("win");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
