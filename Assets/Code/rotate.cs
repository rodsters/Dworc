using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public float zRotate = 100;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, zRotate * Time.deltaTime));
    }
}
