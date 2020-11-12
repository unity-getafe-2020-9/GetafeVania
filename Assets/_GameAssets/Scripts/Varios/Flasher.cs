using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flasher : MonoBehaviour
{
    [Range(0,100)]
    public int rate;
    [Range(0, 1)]
    public float delay;

    private Renderer renderer;
    void Start()
    {
        renderer = GetComponentInChildren<Renderer>();
    }

    public void Flash()
    {
        StartCoroutine("FlashCoroutine");
    }

    IEnumerator FlashCoroutine()
    {
        for (int i = 0; i < rate; i++)
        {
            renderer.enabled = !renderer.enabled;
            yield return new WaitForSeconds(delay);
        }
    }
}
