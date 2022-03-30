using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VoorwerpHouderKouderMouder : MonoBehaviour
{
	public keukenInventaris keukScript;
    public UnityEvent terugGaanNaarInv;

	public void terugNaarInventory()
    {
        //Debug.Log("dit komt alleen als de inventory leeg is");
        if (!keukenInventaris.Instance.inventoryVolOfNiet)
        {
            Debug.Log("dit komt alleen als de inventory leeg is");
            terugGaanNaarInv.Invoke();
        }
	}
}
