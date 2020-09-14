using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindHero : MonoBehaviour
{
    public Vector3 Scale;
    public Transform Father;
    int check = 1;
    public GameObject OpenGameObject;
    
    private void OnMouseDown()
    {
        //int i;
        //if (check == 1)
        //{
        //    for (i = 0; i < DataBase.ArrayCheckBoxItem.Length; i++) 
         //   {
         //       if (DataBase.ArrayCheckBoxItem[i] == 0)
               // {
            Destroy(this.gameObject);
            OpenGameObject.SetActive(true);
            //transform.position = DataBase.ArrayitemListStatic[i].transform.position;
            //transform.localScale = Scale;
            //transform.SetParent(Father);
            //DataBase.ArrayCheckBoxItem[i] = 1;
            //GetComponent<BoxCollider2D>().enabled = false;
            //break;
            //            } 
            //        }

            //        check = 2;
            //        //for (i = 0; i < ArrayCheckBoxItem.Length; i++)
            //        //{
            //        //    Debug.Log(ArrayCheckBoxItem[i]);
            //        //}
            //    }
            //    else if (check == 2)
            //    {

            //    }
        }
}
