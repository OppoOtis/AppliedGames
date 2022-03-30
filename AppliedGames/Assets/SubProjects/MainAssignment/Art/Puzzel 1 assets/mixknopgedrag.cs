using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class mixknopgedrag : MonoBehaviour
{
    private CanvasGroup canvGroup;

    public void Start()
    {
        canvGroup = GetComponent<CanvasGroup>();    
    }

    public void actief() 
    {
        canvGroup.alpha = 1;
        GetComponent<Button>().enabled = true;
        //Debug.Log("Actief");
    }

    public void slapen()
    {
        canvGroup.alpha = .34f;
        GetComponent<Button>().enabled = false;
        //Debug.Log("Slapen");
    }
}
