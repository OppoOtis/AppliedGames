using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class mixertoegangGEDRAG : MonoBehaviour
{
    public bool magMixen;
    public bool greet;
    public UnityEvent mixActief;
    public UnityEvent mixSlaap;
    public HouderDePouder2 houder1;
    public HouderDePouder2 houder2;
    public GameObject nieuweCirkel;
    public Color ultraNieuw;
    public Color deGoeieKleur;
    public keukenInventarisGreet keukenGreet;

    public void mixerChecker()
    {
        //Debug.Log("Mix wordt gecheckt");
        if (houder1.houderHeeftCirkel && houder2.houderHeeftCirkel)
        {
            mixActief.Invoke();
            //Debug.Log("Mix wordt gecheckt en if statement werkt");
            magMixen = true;
        }
        else if(!houder1.houderHeeftCirkel || !houder2.houderHeeftCirkel)
        {
            magMixen = false;
            //Debug.Log("slaap");
            mixSlaap.Invoke();
        }
    }

    public void mixen()
    {
        if(greet){
            nieuweCirkel.SetActive(true);
            if ((houder1.itemInHouder == koelkastVoorwerpen.blauw && houder2.itemInHouder == koelkastVoorwerpen.rood)){
                keukenInventaris.Instance.InventarisVoorwerpenLijst[5].GetComponent<SleepScript>().sleepVoorwerp = koelkastVoorwerpen.paars;
                Debug.Log("GOED");
            }else{
                keukenInventaris.Instance.InventarisVoorwerpenLijst[5].GetComponent<SleepScript>().sleepVoorwerp = koelkastVoorwerpen.verkeerd;
                Debug.Log("SLECHT");
            }
        }else{
            Color nieuw1 = keukenInventaris.Instance.InventarisVoorwerpenLijst[(int)houder2.itemInHouder].gameObject.GetComponent<Image>().color;
            Color nieuw2 = keukenInventaris.Instance.InventarisVoorwerpenLijst[(int)houder1.itemInHouder].gameObject.GetComponent<Image>().color;

            ultraNieuw = (nieuw1 + nieuw2) / 2f;
            nieuweCirkel.SetActive(true);
            nieuweCirkel.GetComponent<Image>().color = ultraNieuw;
            if ((houder1.itemInHouder == koelkastVoorwerpen.blauw && houder2.itemInHouder == koelkastVoorwerpen.rood) || 
                houder2.itemInHouder == koelkastVoorwerpen.blauw && houder1.itemInHouder == koelkastVoorwerpen.rood)             
            {
                keukenInventaris.Instance.InventarisVoorwerpenLijst[5].GetComponent<SleepScript>().sleepVoorwerp = koelkastVoorwerpen.paars;
                Debug.Log("GOED");
            }
            else
            {
                keukenInventaris.Instance.InventarisVoorwerpenLijst[5].GetComponent<SleepScript>().sleepVoorwerp = koelkastVoorwerpen.verkeerd;
                Debug.Log("SLECHT");
            }
        }
        
    }

    public void kleurAancirkel()
    {
        keukenInventaris.Instance.InventarisVoorwerpenLijst[5].gameObject.GetComponent<Image>().color = ultraNieuw;
    }
}
