using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitManager : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            // Debug.Log("End Yourself");
            // Application.Quit();
        }
    }
}
