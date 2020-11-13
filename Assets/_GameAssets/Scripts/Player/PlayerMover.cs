﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [Range(1,10)]
    public float fuerzaSalto=1;
    [Range(1, 1000)]
    public float speed=10;
    private float x;
    private float y;
    private Rigidbody2D rigidbody;
    private Animator animator;
    private bool estaSiendoDespedido = false;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
        }
    }
    private void FixedUpdate()
    {
        Desplazar();
    }

    /// <summary>
    /// Se invoca cuando se topa con los pinchos y estos le lanzan hacia atras.
    /// </summary>
    public void IniciarDespido()
    {
        estaSiendoDespedido = true;
    }
    void Desplazar()
    {
        if (!estaSiendoDespedido)
        {
            rigidbody.velocity = new Vector2(x * Time.deltaTime * speed, rigidbody.velocity.y);
        }
        
        if (Mathf.Abs(rigidbody.velocity.x) > 0.005f)
        {
            animator.SetBool("Running", true);
        } else
        {
            animator.SetBool("Running", false);
        }
    }
    void Saltar()
    {
        if (Mathf.Abs(rigidbody.velocity.y) < 0.01f)
        {
            rigidbody.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        estaSiendoDespedido = false;
    }
}