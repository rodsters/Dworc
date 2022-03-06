using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public const int MAX_HEALTH = 3;
    public int health;
    public int currHealth;

    public HealthSlider healthSlider;

    public int gold = 0;

    void Start()
    {
        healthSlider.SetMaxHealth(MAX_HEALTH);
        health = MAX_HEALTH;
        currHealth = MAX_HEALTH;
        healthSlider.SetHealth(health);
    }

    void Update()
    {
        if (currHealth != health)
        {
            healthSlider.SetHealth(health);
            currHealth = health;
        }
    }
}
