using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keukenInventaris : MonoBehaviour
{
    public enum Item {Hexagon, Driehoek, Kegel, Ruit, Rechthoek, leeg}
    public Item itemInInventaris;
    public Item itemOpSnijPlank;
    public Item voorwerp;

    public List<GameObject> vormenInKoelkast = new List<GameObject>();
    public List<GameObject> vormenInInventaris = new List<GameObject>();
    public List<GameObject> vormenOpSnijPlank = new List<GameObject>();
    public List<Color> vormenKleuren = new List<Color>();

    private void Start()
    {
    }

    public void putInInventory(int boe)
    {
        //Debug.Log(boe);
        vormenInInventaris[(int)itemInInventaris].SetActive(false);
        vormenInKoelkast[(int)itemInInventaris].SetActive(true);
        Debug.Log(itemInInventaris);

        itemInInventaris = (Item)boe;
        voorwerp = itemInInventaris;

        vormenInKoelkast[(int)itemInInventaris].SetActive(false);
        vormenInInventaris[(int)itemInInventaris].SetActive(true);
    }

    public void snijPlankEnter()
    {
        vormenOpSnijPlank[(int)itemInInventaris].SetActive(true);
        itemOpSnijPlank = (Item)itemInInventaris;
    }

    public void snijPlankExit()
    {
        vormenOpSnijPlank[(int)itemInInventaris].SetActive(false);
    }

    public void vormSnijKiezer(int boe)
    {
        vormenOpSnijPlank[(int)itemOpSnijPlank].SetActive(false);
        itemOpSnijPlank = (Item)boe;
        vormenOpSnijPlank[(int)itemOpSnijPlank].SetActive(true);
    }

    public void snijden()
    {
        vormenInInventaris[(int)itemInInventaris].SetActive(false);
        itemInInventaris = itemOpSnijPlank;


        vormenInInventaris[(int)itemInInventaris].gameObject.GetComponent<Image>().color = vormenKleuren[(int)voorwerp];
        Debug.Log(voorwerp);
        vormenInInventaris[(int)itemInInventaris].SetActive(true);
    }

}