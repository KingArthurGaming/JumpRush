using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    
    public GameObject ObjectToHide;
    public GameObject ObjectToShow;
    
    public void Show()
    {
        ObjectToHide.SetActive(false);
        ObjectToShow.SetActive(true);
    }
}


