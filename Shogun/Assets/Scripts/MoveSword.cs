using System.Collections;
using System.Collections.Generic;
using System.Xml.Xsl;
using UnityEngine;

public class MoveSword : MonoBehaviour
{
    public Vector2 VectorHelpFinish;
    public float progress;
    private float Progress;
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, VectorHelpFinish, Progress);
        Progress += progress;
    //    transform.position = Vector2.Lerp(transform.position, new Vector2(2, 2.9f), Progress);
    //    Progress += 0.03f;
    //
    }
}
