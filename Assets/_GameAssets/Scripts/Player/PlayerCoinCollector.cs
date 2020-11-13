using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoinCollector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            //Play sound!!!
            GameObject.Find("GameManager").GetComponent<GameManager>().IncrementarPuntuacion(10);
        }
    }
}
