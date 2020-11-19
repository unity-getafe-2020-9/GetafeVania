using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOrientator : MonoBehaviour
{
    //Referencial al Joystick virtual
    public FixedJoystick vJoystick;
    //Valor de x del input (el que sea)
    float x;

    void Update()
    {
        if (vJoystick.isActiveAndEnabled)
        {
            x = vJoystick.Horizontal;
        } else
        {
            x = Input.GetAxis("Horizontal");
        }
        if (x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
