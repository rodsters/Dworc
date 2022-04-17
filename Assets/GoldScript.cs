using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{
    public float despawnTimer;
    public const float goldDespawn = 4.5f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            //add gold count
            GameObject.Find("speckyTower").GetComponent<TowerManager>().gold++;
            FindObjectOfType<AudioManager>().Play("Coins");
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        despawnTimer = goldDespawn;
    }

    private void Update()
    {
        if (despawnTimer <= 0)
        {
            despawnTimer = goldDespawn;
            Destroy(gameObject);
        }
        else
        {
            despawnTimer -= Time.deltaTime;
        }
    }
}
