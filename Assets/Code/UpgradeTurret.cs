using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;

public class UpgradeTurret : MonoBehaviour
{
    public int currUpgrade = 1;
    public int currUpgradeCool = 1;

    public TowerManager tower;
    public shooting shoot;

    public Sprite twoGun;
    public Sprite fourGun;

    void Update()
    {
        //if (Input.GetKeyDown("space"))
        //{
        //    Upgrade();
        //}
    }

    public void UpgradeCooldown()
    {
        if (tower.gold >= 5 && currUpgradeCool == 1)
        {
            currUpgradeCool *= 2;
            tower.gold-=5;
        }

        if (currUpgradeCool == 2) {
            shoot.cooldown1 = 0.5f;
        }
    }

    public void UpgradeTurrets() {
        if (tower.gold >= 1 && currUpgrade == 1)
        {
            currUpgrade *= 2;
            tower.gold--;
        }
        if (tower.gold >= 5 && currUpgrade == 2)
        {
            currUpgrade *= 2;
            tower.gold-=5;
        }
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
