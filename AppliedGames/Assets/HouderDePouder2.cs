using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class HouderDePouder2 : MonoBehaviour, IDropHandler
{
    public List<GameObject> houderVoorwerpenSeks = new List<GameObject>();
    public bool houderHeeftCirkel;
    public UnityEvent checkOfMagMixenEven;
    public koelkastVoorwerpen itemInHouder;

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
            foreach (Transform child in transform)
            {
                //Debug.Log(child.name);
                if (child.gameObject != eventData.pointerDrag.gameObject)
                {
                    //Debug.Log(child.name);
                    child.gameObject.SetActive(false);
                }
            }
            keukenInventaris.Instance.inventoryVolOfNiet = false;

            eventData.pointerDrag.GetComponent<SleepScript>().inHouder = true;
            itemInHouder = eventData.pointerDrag.GetComponent<SleepScript>().sleepVoorwerp;
            houderVoorwerpenSeks[(int)eventData.pointerDrag.GetComponent<SleepScript>().sleepVoorwerp].SetActive(true);
            eventData.pointerDrag.SetActive(false);

            houderHeeftCirkel = true;
            checkOfMagMixenEven.Invoke();
        }
    }
}
