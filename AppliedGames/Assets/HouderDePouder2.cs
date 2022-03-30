using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HouderDePouder2 : MonoBehaviour, IDropHandler
{
    public List<GameObject> houderVoorwerpenSeks = new List<GameObject>();

    public void Start()
    {
        foreach (Transform child in transform)
        {
            houderVoorwerpenSeks.Add(child.gameObject);
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            keukenInventaris.Instance.inventoryVolOfNiet = false;
            eventData.pointerDrag.GetComponent<SleepScript>().inHouder = true;
            houderVoorwerpenSeks[(int)eventData.pointerDrag.GetComponent<SleepScript>().sleepVoorwerp].SetActive(true);
            eventData.pointerDrag.SetActive(false);
        }
    }
}
