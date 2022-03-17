using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keukenInventaris : MonoBehaviour
{
    public enum Item { Vierkant, Hexagon, Driehoek, Kegel, Ruit, Rechthoek}
    public Item itemInInventaris;
    public Item voorwerp;

    public List<GameObject> vormenInKoelkast = new List<GameObject>();
    public List<GameObject> vormenInInventaris = new List<GameObject>();

    public void putInInventory(int boe)
    {
        vormenInInventaris[(int)itemInInventaris].SetActive(false);
        vormenInKoelkast[(int)itemInInventaris].SetActive(true);

        itemInInventaris = (Item)boe; 

        vormenInKoelkast[(int)itemInInventaris].SetActive(false);
        vormenInInventaris[(int)itemInInventaris].SetActive(true);
    }
}