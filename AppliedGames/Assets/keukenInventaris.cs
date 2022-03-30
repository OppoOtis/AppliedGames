using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum koelkastVoorwerpen { rood, blauw, groen, oranje, geel, leeg };


public class keukenInventaris : Singleton<keukenInventaris>
{
    koelkastVoorwerpen voorwerpInInventory;

    public List<GameObject> InventarisVoorwerpenLijst = new List<GameObject>();
    public List<GameObject> koelkastVoorwerpenLijst = new List<GameObject>();
    public GameObject koelkast;
    public bool inventoryVolOfNiet;

    public void Awake()
    {
        Instance = this;
    }


    public void Start()
    {
        foreach (Transform child in transform)
        {
            InventarisVoorwerpenLijst.Add(child.gameObject);
        }

        foreach (Transform child in koelkast.transform)
        {
            koelkastVoorwerpenLijst.Add(child.gameObject);
        }
    }

    public void putInInventory(int boe)
    {
        inventoryVolOfNiet = true;
        InventarisVoorwerpenLijst[(int)voorwerpInInventory].SetActive(false);
        voorwerpInInventory = (koelkastVoorwerpen)boe;
        InventarisVoorwerpenLijst[(int)voorwerpInInventory].SetActive(true);
    }

    public void inventarisLeegMaker()
    {
        inventoryVolOfNiet = false;
    }
}