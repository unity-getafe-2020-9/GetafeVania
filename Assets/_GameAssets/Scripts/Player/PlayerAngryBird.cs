using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAngryBird : MonoBehaviour
{
    public float forceScale;
    public Transform posicionInicial;
    // Start is called before the first frame update

    private void Update()
    {
        if (Input.touchCount > 0)//Input.touchCount -->Indica cuantos punteros (dedos) hay sobre la pantalla
        {
            Touch t = Input.GetTouch(0);//Nos proporciona la info del primer puntero que se posa en la pantalla
            switch (t.phase)
            {
                case TouchPhase.Began:
                    print("Tocando");
                    //Detectar que seleccionado el player
                    break;
                case TouchPhase.Ended:
                    print("Liberando");
                    Lanzar();
                    break;
                case TouchPhase.Moved:
                    print("Movimiendo");
                    Vector3 np = Camera.main.ScreenToWorldPoint(t.position);
                    np = new Vector3(np.x, np.y, 0);//Corregir la z
                    transform.position = np;
                    break;
            }
        }
    }

    void Lanzar()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
        Vector2 direction = posicionInicial.position - transform.position;
        GetComponent<Rigidbody2D>().AddForce(direction * forceScale);
    }

    /*
    private void OnMouseDrag()
    {
        //Conversión de las coordenadas de la pantalla a las coordenadas del mundo
        Vector3 np = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        np = new Vector3(np.x, np.y, 0);//Corregir la z
        transform.position = np;
    }

    private void OnMouseUp()
    {
        Lanzar();
    }
    */
}
