using System.Collections;
using System.Collections.Generic;
using System.Xml.Xsl;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MoveItemsPanel : MonoBehaviour
{
    public Sprite imag1;
    public Sprite imag2;
    public Vector2 VectorHelpFinishButton1;
    public Vector2 VectorHelpFinishButton2;
    public float speed;
    private bool move,check=true;
    void Start()
    {

    }
    public void OnMouseDown()
    {
        if (check)
        {
            GetComponent<SpriteRenderer>().sprite = imag1;
            move = true;
            check = false;
        }
        else
        { 
            GetComponent<SpriteRenderer>().sprite = imag2;
            move = false;
            check = true;
        }
    }
    void FixedUpdate()
    {

        if (move)
        {
            transform.position = Vector2.MoveTowards(transform.position, VectorHelpFinishButton1, speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, 3f);
        }
        else 
        {
            transform.position = Vector2.MoveTowards(transform.position, VectorHelpFinishButton2, speed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, 3f);
        }
    }

}
