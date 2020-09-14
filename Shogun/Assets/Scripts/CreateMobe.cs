using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMobe : MonoBehaviour
{
    int j = 0;
    public GameObject Mobe;
    void Start()
    {
        if (j < 5) {
            Instantiate(Mobe, new Vector2(Random.Range(-9.0f, 9.0f), Random.Range(-2.0f, 5.0f)), Quaternion.identity);
            Invoke("Start", Random.Range(3.5f, 4f));
            j++;
        }
    }
}
