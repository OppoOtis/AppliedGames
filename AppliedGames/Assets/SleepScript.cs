using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class SleepScript : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    public Transform inventoryPos;
    private RectTransform rectTrans;
    private Canvas canvas;
    private CanvasGroup CanvasGroup;

    public GameObject houder;
    public koelkastVoorwerpen sleepVoorwerp;
    public bool inHouder;


    private void Awake()
    {
        inventoryPos = transform.parent.transform;
        rectTrans = GetComponent<RectTransform>();
        CanvasGroup = GetComponent<CanvasGroup>();
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        gameObject.SetActive(false);
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        CanvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        TERUGGAANNUUUUUU();
    }

    public void TERUGGAANNUUUUUU()
    {
        transform.position = inventoryPos.position;
        CanvasGroup.blocksRaycasts = true;
    }
}