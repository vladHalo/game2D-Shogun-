using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public  GameObject[] ArrayitemList;
    public static GameObject[] ArrayitemListStatic;
    public static int[] ArrayCheckBoxItem = new int[] { 0, 0, 0, 0, 0, 0 };
    private void Start()
    {
        ArrayitemListStatic=ArrayitemList;
    }
}
