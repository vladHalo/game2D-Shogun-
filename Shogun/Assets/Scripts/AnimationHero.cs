using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonBones;
public class AnimationHero : MonoBehaviour
{
    public BoxCollider2D box;
    private bool Check1=true,Check2=true,Check3=true;
    public Joystick joystick;
    private UnityArmatureComponent CheckPlay;
    void Start()
    {
        CheckPlay = this.GetComponent<UnityArmatureComponent>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (joystick.Horizontal != 0.0f)
        {
            //box.GetComponent<BoxCollider2D>().enabled = false;
            if (Check1)
            {
                CheckPlay.animation.Play("Run"); Check1 = false; Check2 = true; Check3 = true;
            }
            if (!CheckPlay.animation.isPlaying)
                CheckPlay.animation.Play("Run");
        }
        else if (joystick.Horizontal == 0.0f)
        {
            //box.GetComponent<BoxCollider2D>().enabled = false;
            if (Check2)
            {
                CheckPlay.animation.Play("Idle"); Check2 = false;Check1 = true; Check3 = true;
            }
            if (!CheckPlay.animation.isPlaying)
                CheckPlay.animation.Play("Idle");
        }
        else if(joystick.Vertical>=0.5f)
        {
            //box.GetComponent<BoxCollider2D>().enabled = false;
            if (Check3)
            {
                CheckPlay.animation.Play("Jump"); Check3 = false; Check1 = true; Check2 = true;
            }
            if (!CheckPlay.animation.isPlaying)
                CheckPlay.animation.Play("Jump");
        }
    }
    public void Attack()
    {
        //box.GetComponent<BoxCollider2D>().enabled = true;
        CheckPlay.animation.Play("Atack",1);
    }
    public void Block()
    {
        CheckPlay.animation.Play("Block", 1);
    }
}
