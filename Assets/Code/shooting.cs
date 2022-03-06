using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shooting : MonoBehaviour
{
    public int firePointUpgrades = 1;
    public Transform firePoint1;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    GameObject bullet;

    public GameObject bulletPrefab;
    Rigidbody2D rb;

    public float bulletForce = 20f;

    public Image cooldownIcon;
    public float cooldown1 = 5;
    bool isCooldown = false;

    private void Start()
    {
        cooldownIcon.fillAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && isCooldown == false)
        {
            if(firePointUpgrades >= 4)
            {
                isCooldown = true;
                cooldownIcon.fillAmount = 1;
                bullet = Instantiate(bulletPrefab, firePoint4.position, firePoint4.rotation);
                rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint4.up * bulletForce, ForceMode2D.Impulse);
            }

            if (firePointUpgrades >= 3)
            {
                isCooldown = true;
                cooldownIcon.fillAmount = 1;
                bullet = Instantiate(bulletPrefab, firePoint3.position, firePoint3.rotation);
                rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint3.up * bulletForce, ForceMode2D.Impulse);
            }

            if (firePointUpgrades >= 2)
            {
                isCooldown = true;
                cooldownIcon.fillAmount = 1;
                bullet = Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
                rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint2.up * bulletForce, ForceMode2D.Impulse);
            }

            isCooldown = true;
            cooldownIcon.fillAmount = 1;
            bullet = Instantiate(bulletPrefab, firePoint1.position, firePoint1.rotation);
            rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint1.up * bulletForce, ForceMode2D.Impulse);
        }

        if(isCooldown)
        {
            cooldownIcon.fillAmount -= 1 / cooldown1 * Time.deltaTime;

            if(cooldownIcon.fillAmount <= 0)
            {
                cooldownIcon.fillAmount = 0;
                isCooldown = false;
            }
        }
    }
}
