using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text waveTexts;

    public void Setup(int wave)
    {
        gameObject.SetActive(true);
        waveTexts.text = wave.ToString() + " Waves";
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Rodney Shop");
    }
}
