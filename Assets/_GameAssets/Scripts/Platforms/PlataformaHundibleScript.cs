using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaHundibleScript : MonoBehaviour
{
    bool estaBajando = false;
    public float speed;

    private void Update()
    {
        if (estaBajando)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!estaBajando && collision.gameObject.CompareTag("Player"))
        {
            estaBajando = true;
        }
    }

    private void OnBecameInvisible()
    {
        print("NO ME VES");
        Destroy(gameObject);
    }
}
