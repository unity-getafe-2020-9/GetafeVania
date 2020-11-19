﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerSoundManager psm;
    public bool x;
    private void Awake()
    {
        x = false;
        psm = GetComponent<PlayerSoundManager>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Key"))
        {
            psm.PlayAudioKey();
            GameObject.Find("GameManager").GetComponent<GameManager>().RecogerLlave();
            Destroy(collision.gameObject);
        }
    }



    public void RecibirDanyo()
    {
        psm.PlayAudioDamage();
    }
}
