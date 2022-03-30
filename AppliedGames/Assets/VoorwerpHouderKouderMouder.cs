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
        if (keukScript.inventoryVolOfNiet)
        {
            terugGaanNaarInv.Invoke();
            Debug.Log("dit komt alleen als de inventory leeg is");
        }
	}
}
