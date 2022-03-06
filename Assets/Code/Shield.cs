using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public float speed = -100;

    private void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, speed) * Time.deltaTime);
    }
}
