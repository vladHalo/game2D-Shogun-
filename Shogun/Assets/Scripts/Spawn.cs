using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject comet;
    void Start()
    {
        Instantiate(comet, new Vector2(Random.Range(-21.0f,3.0f), transform.position.y),Quaternion.identity);
        Invoke("Start", Random.Range(3.5f, 8f));
    }
}
