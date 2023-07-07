using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image fillImage;
    private Slider Slider;

    void Awake()
    {
        Slider = GetComponent<Slider>();
    }

    public void SetMaxHealth(int health)
    {
        fillImage.enabled = true;
        Slider.maxValue = health;
        Slider.value = health;
    }

    public void SetHealth(int health)
    {
        Slider.value = health;

        if(Slider.value <= 0)
        {
            fillImage.enabled = false;
        }
    }
}
