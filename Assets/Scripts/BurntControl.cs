using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        StartCoroutine("HotScene"); 
    }

    IEnumerator HotScene()
    {
        myAnimator.SetTrigger("Burnt");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
