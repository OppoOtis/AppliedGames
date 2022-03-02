using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowSizer : MonoBehaviour
{
    RectTransform arrow;
    void Start(){
        arrow = gameObject.GetComponent<RectTransform>();
    }
    public void HoverOn(){
        arrow.Rotate(new Vector3(0f,0f,6f));
        arrow.localScale += new Vector3(0.2f,0.2f,0.2f);
    }
    public void HoverOff(){
        arrow.Rotate(new Vector3(0f,0f,-6f));
        arrow.localScale -= new Vector3(0.2f,0.2f,0.2f);
    }
}
