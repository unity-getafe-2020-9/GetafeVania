using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [Range(1,10)]
    public float fuerzaSalto=1;
    [Range(1, 1000)]
    public float speed=10;
    float x;
    float y;
    Rigidbody2D rigidbody;
    Animator animator;
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
    void Desplazar()
    {
        rigidbody.velocity = new Vector2(x * Time.deltaTime * speed, rigidbody.velocity.y);
        if (Mathf.Abs(rigidbody.velocity.x) > 0)
        {
            animator.SetBool("Running", true);
        } else
        {
            animator.SetBool("Running", false);
        }
    }

    void Saltar()
    {
        rigidbody.AddForce(Vector2.up * fuerzaSalto, ForceMode2D.Impulse);
    }
}
