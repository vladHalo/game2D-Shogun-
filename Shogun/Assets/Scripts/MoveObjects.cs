using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    public float numberDestroyScript;
    public float numberStopObject;
    public bool side;
    float posYmove;
    float posZmove;
    void Start()
    {
        posYmove = transform.position.y;
        posZmove = transform.position.z;
    }

    private void Update()
    {
        if (side==true)
        {
            if (transform.position.x >= numberDestroyScript) Destroy(gameObject.GetComponent<MoveObjects>());
        }else
        {
            if (transform.position.x <= numberDestroyScript) Destroy(gameObject.GetComponent<MoveObjects>());
        }
    }
    void OnMouseDrag()
    {
        Vector2 Cursor = Input.mousePosition;
        Cursor = Camera.main.ScreenToWorldPoint(Cursor);
        if (Cursor.x > numberStopObject)
        {
            transform.position = Cursor;
            transform.position = new Vector3(transform.position.x, posYmove,posZmove);
        } 
    }
}