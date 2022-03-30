using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VoorwerpHouderKouderMouder : MonoBehaviour
{
    public UnityEvent terugGaanNaarInv;

	public void terugNaarInventory()
    {
        
        //Debug.Log("dit komt alleen als de inventory leeg is");
        if (!keukenInventaris.Instance.inventoryVolOfNiet)
        {
            //Debug.Log("dit komt alleen als de inventory leeg is");

            transform.parent.GetComponent<HouderDePouder2>().houderHeeftCirkel = false;
            transform.parent.GetComponent<HouderDePouder2>().checkOfMagMixenEven.Invoke();
            transform.parent.GetComponent<HouderDePouder2>().itemInHouder = koelkastVoorwerpen.leeg;
            terugGaanNaarInv.Invoke();
        }
	}
}
