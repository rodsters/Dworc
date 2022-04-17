using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameOver gameOver;
    public int wave;

    public void GameEnd()
    {
        gameOver.Setup(wave);
    }
}
