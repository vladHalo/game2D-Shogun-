using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStars : MonoBehaviour
{
    public float speedStar;
    public Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity= new Vector2(0.951f*speedStar, -0.309f*speedStar);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Delete")
            Destroy(this.gameObject);
    }
}
