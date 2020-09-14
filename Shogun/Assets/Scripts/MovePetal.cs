using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePetal : MonoBehaviour
{
    public float speedStar;
    public Rigidbody2D rb;
    int RndPetal;
    float RndPetalRange,SinPetal,CosPetal;
    void Start()
    {
        RndPetal = Random.Range(1, 10);
        RndPetalRange = Random.Range(230f,310f);
        SinPetal = Mathf.Sin(RndPetalRange);
        CosPetal= Mathf.Cos(RndPetalRange);
        if (RndPetalRange > 270f) SinPetal *= -1;
        else { SinPetal *= -1; CosPetal *= -1; }
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(SinPetal * speedStar, CosPetal * speedStar);
    }
}
