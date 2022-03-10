using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 100;
    public int dropRateOutOf100 = 100;
    public GameObject theDrops;
    public GameObject enemy;
    public Transform dropPoint;
    public WaveManager wave;
    public int enemyDifficulty;

    public void TakeDamage(int damage)
    {
        wave = GameObject.Find("Wave Manager").GetComponent<WaveManager>();
        health -= damage;
        if (health <= 0)
        {
            wave.waveSize--;
            Destroy(enemy);

            //need to figure out how to delay

            if (dropRateOutOf100 > Random.Range(0, 100))
            {
                Instantiate(theDrops, dropPoint.position, dropPoint.rotation);
            }
        }
    }
}
