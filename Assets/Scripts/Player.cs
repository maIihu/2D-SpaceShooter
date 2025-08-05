using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script defines which sprite the 'Player" uses and its health.
/// </summary>

public class Player : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private UIHealthBar healthBar;
    
    public GameObject destructionFX;
    public static Player instance;

    private float _currentHealth;

    private void Awake()
    {
        if (instance == null) 
            instance = this;
    }

    private void Start()
    {
        _currentHealth = maxHealth;
    }

    //method for damage proceccing by 'Player'
    public void GetDamage(int damage)   
    {
        _currentHealth -= damage;
        healthBar.ChangeUIHealth(_currentHealth, maxHealth);
        if (_currentHealth <= 0)
            Destruction();
    }    

    //'Player's' destruction procedure
    void Destruction()
    {
        Instantiate(destructionFX, transform.position, Quaternion.identity); //generating destruction visual effect and destroying the 'Player' object
        Destroy(gameObject);
    }
}
















