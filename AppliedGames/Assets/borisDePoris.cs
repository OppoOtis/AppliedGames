using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class borisDePoris : MonoBehaviour, IDropHandler
{
    public Sprite borisBlij;
    public Sprite borisBoos;
    public GameObject spraakwolk;
    public GameObject snackjeVanBoris;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            if (eventData.pointerDrag.gameObject.GetComponent<SleepScript>().sleepVoorwerp == koelkastVoorwerpen.paars)
            {
                Debug.Log("JE HEBT GEWONNEN");
                GetComponent<Image>().sprite = borisBlij;
                spraakwolk.SetActive(false);
                snackjeVanBoris.SetActive(true);    
            }
            else
            {
                Debug.Log("loseeeer");
                GetComponent<Image>().sprite = borisBoos;

            }
        }
    }
}
