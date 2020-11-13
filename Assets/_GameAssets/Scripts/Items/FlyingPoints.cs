using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingPoints : MonoBehaviour
{
    [Range(0, 10)]
    public float speed;

    public SpriteRenderer spriteRenderer0;
    public SpriteRenderer spriteRenderer1;
    private int points = 47;
    public void SetPoints(int _points)
    {
        this.points = _points;
    }
    private void Awake()
    {
        if (points >= 10)
        {
            spriteRenderer0.sprite = Resources.Load<Sprite>("Digitos/hud" + points.ToString().Substring(0, 1));
            spriteRenderer1.sprite = Resources.Load<Sprite>("Digitos/hud" + points.ToString().Substring(1, 1));
        } else
        {
            spriteRenderer1.sprite = Resources.Load<Sprite>("Digitos/hud" + points.ToString().Substring(0, 1));
        }
    }
}
