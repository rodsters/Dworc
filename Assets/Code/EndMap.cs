using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMap: MonoBehaviour
{
    public WaveManager wave;

    void Start()
    {
        wave = GameObject.Find("Wave Manager").GetComponent<WaveManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            GameObject.Find("speckyTower").GetComponent<TowerManager>().health--;
            if (collision.transform.parent != null)
            {
                Destroy(collision.transform.parent.gameObject);
            }
            else
            {
                Destroy(collision.gameObject);
            }
            wave.waveSize--;
        }
    }
}
