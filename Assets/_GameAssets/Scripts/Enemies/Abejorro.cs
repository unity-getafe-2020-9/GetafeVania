using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abejorro : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().QuitarVida();
            Destroy(transform.parent.gameObject);
        }
    }
}
