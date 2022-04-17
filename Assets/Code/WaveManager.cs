using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveManager : MonoBehaviour
{
    public const int MAX_WAZE_SIZE = 1000;

    int i;
    public int waveSize;
    private int initWaveSize;
    public int waveNumber;

    public int difficulty;
    public int currDifficulty;

    public Vector3 spawnPoint;
    public GameObject[] enemyTypes;
    public GameObject[] currentEnemies;

    public bool increaseSpeed;
   
    float spawnCooldown;
    float waveCooldown;

    bool waveAlive;
    bool spawning;
    bool bossSpawning;

    public Text waveDisplay;

    void Start()
    {
        i = 0;
        waveNumber = 0;
        difficulty = 0;
        currDifficulty = 0;

        spawnCooldown = 2.0f;
        waveCooldown = 5.0f;

        currentEnemies = new GameObject[MAX_WAZE_SIZE];

        waveAlive = false;
        spawning = false;
        bossSpawning = false;

        StartSpawning();
    }

    void Update()
    {  
        if (currDifficulty >= difficulty)
        {
            spawning = false;
        }

        if (waveSize == 0 && spawning == false)
        {
            waveAlive = false;
        }

        if (spawning == true && currDifficulty < difficulty)
        {   if (bossSpawning)
            {
                if (spawnCooldown > 0)
                {
                    spawnCooldown -= Time.deltaTime;
                }
                else
                {
                    spawnCooldown = 2.0f;
                    if (difficulty == currDifficulty + 10 || difficulty == currDifficulty + 9)
                    {
                        SpawnBoss();
                    }
                    else
                    {
                        SpawnEnemy();
                    }
                }
            }
            else
            {
                if (spawnCooldown > 0)
                {
                    spawnCooldown -= Time.deltaTime;
                }
                else
                {
                    SpawnEnemy();
                    spawnCooldown = 2.0f;
                }
            }
        }
        else if (waveAlive == false)
        {
            if (waveCooldown > 0)
            {
                waveCooldown -= Time.deltaTime;
            }
            else
            {
                StartSpawning();
                currDifficulty = 0;
                i = 0;
                waveCooldown = 5.0f;
            }
        }
    }

    int getDifficulty()
    {
        int newDifficulty = Mathf.RoundToInt(7 * Mathf.Pow((waveNumber / 2.0f), 2.0f) + 2.0f * waveNumber + 2.0f);
        Debug.Log("" + newDifficulty);

        return newDifficulty;
    }

    void StartSpawning()
    {
        waveAlive = true;
        spawning = true;

        waveNumber++;
        if (waveNumber < 10)
        {
            waveDisplay.text = "0  0  " + waveNumber;
        }
        else if (waveNumber >= 10 && waveNumber < 100)
        {
            waveDisplay.text = "0  " + waveNumber/10 + "  " + waveNumber%10;
        }
        else
        {
            waveDisplay.text = waveNumber / 100 + "  " + (waveNumber % 100) / 10 + "  " + waveNumber%10;
        }
        difficulty = getDifficulty();
        if (difficulty >= MAX_WAZE_SIZE)
        {
            difficulty = MAX_WAZE_SIZE - 1;
        }

        //if (waveNumber % 2 == 0)    // 2 is a debugging value to make sure code works.
        //{
        //    bossSpawning = true;
        //}
        //else
        //{
        //    bossSpawning = false;
        //}

        waveSize = 0;
        initWaveSize = waveSize;
        // Debug.Log(waveSize);
    }

    void SpawnEnemy()
    {
        int enemy = Random.Range(0, 2);
        currentEnemies[i] = Instantiate(enemyTypes[enemy], spawnPoint, Quaternion.identity) as GameObject;
        currDifficulty ++;
        i++;
        waveSize++;
    }

    void SpawnBoss()
    {
        
        int enemy = 1;
        currentEnemies[i] = Instantiate(enemyTypes[enemy], spawnPoint, Quaternion.identity) as GameObject;
        currDifficulty += enemy + 1;
        Debug.Log("\"Suck my balls\" - Gabe Cochran");
        i++;
        waveSize++;
    }
}
