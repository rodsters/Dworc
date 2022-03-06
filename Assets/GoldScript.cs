using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            //add gold count
            GameObject.Find("speckyTower").GetComponent<TowerManager>().gold++;
            Destroy(gameObject);
        }
    }
}
