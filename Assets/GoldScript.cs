using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{
    // public 
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            //add gold count
            //GameObject.Find("speckyTower").GetComponent<TowerManager>().gold++;
            GameObject.Find("speckyTower 2").GetComponent<TowerManager>().gold++;
            Destroy(gameObject);
        }
    }
}
