using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TowerManager : MonoBehaviour
{
    public const int MAX_HEALTH = 3;
    public int health;
    public int currHealth;

    public HealthSlider healthSlider;

    public Text goldDisplay;

    public int gold = 0;

    public SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

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
        goldDisplay.text = "Gold " + gold;
    }
    
    public void changeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }
}
