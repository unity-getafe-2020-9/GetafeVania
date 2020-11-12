using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().RecogerLlave();
            Destroy(collision.gameObject);
        }
    }
}
