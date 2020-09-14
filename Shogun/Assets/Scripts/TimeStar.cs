using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStar : MonoBehaviour
{
    public Animator anim;
    public bool check = true;
    public float timerStarAnimation;
    void Start()
    {
        anim = GetComponent<Animator>();
        timerStarAnimation = Random.Range(5, 10);
    }
    public void FixedUpdate()
    {
        timerStarAnimation -= Time.deltaTime;
        if (timerStarAnimation <= 0 && check == false)
        {
            anim.SetBool("StartStar", false);
            check = true;
            timerStarAnimation = Random.Range(5, 10);
        }
        else if (timerStarAnimation <= 0 && check == true)
        {
            anim.SetBool("StartStar", true);
            check = false;
            timerStarAnimation = 4.26f;
        }
    }
}