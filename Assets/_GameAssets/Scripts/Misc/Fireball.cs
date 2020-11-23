using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("EnemigoDestruible"))
        {
            Destroy(collision.transform.parent.gameObject);//Ojo a la estructura
        }
        Destroy(gameObject);
    }
}
