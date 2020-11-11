using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrientator : MonoBehaviour
{
    float x;
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        if (x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
