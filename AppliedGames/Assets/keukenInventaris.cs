using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keukenInventaris : MonoBehaviour
{
    public enum Item { vierkant, hexagon, driehoek, kegel, ruit, rechthoek}
    public Item itemInInventaris;
    public Item voorwerpInKoelkast;

    public void putInInventory()
    {
        voorwerpInKoelkast = itemInInventaris;
    }
}
