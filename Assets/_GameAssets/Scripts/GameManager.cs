using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum Estado { Menu, Pause, Playing, GameOver}

    [Header("ESTADO DEL JUEGO")]
    //Estado
    public Estado estado = Estado.Menu;

    [Header("CONFIGURACION")]
    //Configuracion
    public bool soundOn = true;
    public bool musicOn = true;

    [Header("ESTADO")]
    //Estado del juego
    public int puntuacion;
    public int numeroVidasMaximo;
    public int numeroVidas;

    [Header("INVENTARIO")]
    //Inventario
    public bool hasKey = false;

    [Header("POWERS UP")]
    //PowerUp
    //-->Super Velocidad
    public float superSpeedValue;
    public bool superSpeed = false;
    //-->Super Salto
    public float superJumpValue;
    public bool superJump = false;
    //-->Modo Divino
    public float godModeTime;
    public bool godMode = false;

    [Header("CONFIGURACION UI")]
    //UI
    public GameObject prefabImagenVida;
    public GameObject panelVidas;
    
    private GameObject player;

    private void Awake()
    {
        numeroVidas = numeroVidasMaximo;
        GetComponent<UIManager>().CrearVidasUI(numeroVidas, prefabImagenVida, panelVidas);
        player = GameObject.Find("Player");
    }
    public void QuitarVida()
    {
        numeroVidas--;
        if (numeroVidas == 0)
        {
            //GameOver
        } else
        {
            //player.GetComponentInChildren<Flasher>().Flash();
            GetComponent<UIManager>().CrearVidasUI(numeroVidas, prefabImagenVida, panelVidas);
        }
    }
    public void RecogerLlave()
    {
        hasKey = true;
        GetComponent<UIManager>().ActivarLlaveUI();
    }

    public void IncrementarPuntuacion(int puntos)
    {
        puntuacion += puntos;
    }
    public void GuardarEstado()
    {

    }
    public void RecuperarEstado()
    {

    }
}
