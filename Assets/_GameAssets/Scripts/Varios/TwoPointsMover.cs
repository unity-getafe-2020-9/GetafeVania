﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoPointsMover : MonoBehaviour
{
    public Transform origen;
    public Transform destino;
    public GameObject objetoAMover;
    public float speed;
    private Vector2 nuevaPosicion;
    private float pct=0f;//Porcentaje de desplazamiento
    void Update()
    {
        nuevaPosicion = Vector2.Lerp(origen.position, destino.position, pct);
        objetoAMover.transform.position = nuevaPosicion;
        pct += Time.deltaTime * speed;
        if (pct>=1)
        {
            pct = 1;
            speed*= -1;
            objetoAMover.transform.localScale = new Vector2(1, 1);
        }
        if (pct <= 0)
        {
            pct = 0;
            speed*= -1;
            objetoAMover.transform.localScale = new Vector2(-1, 1);
        }
    }
}
