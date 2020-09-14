using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckButtonBox : MonoBehaviour
{
    public Sprite imagChecked;
    public Sprite imagChecked2;
    bool check = true;
    private void OnMouseDown()
    {
        if (check)
        {
            GetComponent<SpriteRenderer>().sprite = imagChecked; check = false;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = imagChecked2; check = true;
        }
    }
}
