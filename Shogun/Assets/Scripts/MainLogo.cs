using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class MainLogo : MonoBehaviour
{
    public GameObject CanvasLogoCompanyDelete; 
    public GameObject CanvasNameGameOpen;

    public void lookFor()
    {
        Destroy(CanvasLogoCompanyDelete.gameObject);
        CanvasNameGameOpen.gameObject.SetActive(true);
    }
}
