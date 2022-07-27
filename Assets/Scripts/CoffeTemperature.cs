using UnityEngine;
using UnityEngine.UI;
using System;


public class CoffeTemperature : MonoBehaviour
{
    float coffeeTemperature = 130.0f;
    float hotLimitTemperature = 80.0f;
    float coldLimitTemperature = 30.0f;

    public Text myText;
    public ParticleSystem smoke;
    public ParticleSystem lightSmoke;

    public static event Action burning;
    public static event Action freezing;
    public static event Action winning;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TemperatureTest();
        }

        if (coffeeTemperature <= 85)
        {
            smoke.Stop();
        }

        if (coffeeTemperature <= 70)
        {
            lightSmoke.Stop();
        }

        coffeeTemperature -= Time.deltaTime * 5f;

        myText.text = "Temperature: " + coffeeTemperature;
    }


    void TemperatureTest()
    {
        // If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            burning?.Invoke();
            print("Coffee is too hot.");

        }
        // If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            freezing?.Invoke();
            print("Coffee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            winning?.Invoke();
            print("Coffee is just right.");
        }
    }
}
