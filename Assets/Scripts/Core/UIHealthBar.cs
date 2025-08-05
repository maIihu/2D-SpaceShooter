using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHealthBar : MonoBehaviour
{
    [SerializeField] private Image fillHealth;

    public void ChangeUIHealth(float current, float max)
    {
        fillHealth.fillAmount = current / max;
    }
}
