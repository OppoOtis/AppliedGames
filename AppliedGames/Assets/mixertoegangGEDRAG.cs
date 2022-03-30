using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class mixertoegangGEDRAG : MonoBehaviour
{
    public bool magMixen;
    public UnityEvent mixActief;
    public UnityEvent mixSlaap;
    public HouderDePouder2 houder1;
    public HouderDePouder2 houder2;

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
            Debug.Log("slaap");
            mixSlaap.Invoke();
        }
    }
}
