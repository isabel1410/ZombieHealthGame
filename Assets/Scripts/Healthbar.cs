using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Healthbar : MonoBehaviour
{
    public Slider slider;
    
    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.minValue = 0;

        slider.value = health;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }

    public void LoseHealth(float damage)
    {
        slider.value -= damage;
    }

    public void GainHealth(float health)
    {
        slider.value += health;
    }
}
