using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 25;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag == "Enemy")
        {
            EnemyHealth enemy = hitInfo.GetComponent<EnemyHealth>();
            enemy.TakeDamage(damage);
            Destroy(gameObject);
            return;
        }
        else if (hitInfo.tag == "Shield")
        {
            Destroy(gameObject);
            return;
        }
        else if (hitInfo.tag == "Game Boundary")
        {
            Destroy(gameObject);
            return;
        }

    }

}
