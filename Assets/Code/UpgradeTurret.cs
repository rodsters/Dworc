using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeTurret : MonoBehaviour
{
    public int currUpgrade = 1;

    public TowerManager tower;
    public shooting shoot;

    public Sprite twoGun;
    public Sprite fourGun;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Upgrade();
        }
    }

    public void Upgrade() {
        currUpgrade *= 2;
        //currUpgrade++;

        if (currUpgrade == 2)
        {
            tower.changeSprite(twoGun);
            shoot.firePointUpgrades = 2;
        }
        /*
        if (currUpgrade == 3)
        {
            tower.changeSprite(fourGun);
            shoot.firePointUpgrades = 3;
        }
        */
        if (currUpgrade == 4)
        {
            tower.changeSprite(fourGun);
            shoot.firePointUpgrades = 4;
        }
    }
}
