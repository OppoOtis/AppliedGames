using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPicker : MonoBehaviour
{
    public bool dragging;
    public bool hoverOverInteractable;
    public int foodValue;
    public FoodEquip foodEquip;
    public Texture2D[] foodImages;
    public Texture2D mouse;
    public GameObject goodBoris;
    public GameObject dankje;
    public GameObject room;
    public GameObject bozeBoris;
    public GameObject restart;
    public GameObject boris;

    void Start(){
        dragging = false;
        hoverOverInteractable = false;
        Cursor.SetCursor(mouse, Vector2.zero, CursorMode.ForceSoftware);

    }
    public void DragingInventoryItem(){
        if(dragging == false){
            foodValue = foodEquip.foodValue;
            dragging = true;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Cursor.SetCursor(foodImages[foodValue], Vector2.zero, CursorMode.ForceSoftware);
        }
    }
    public void ResetInventoryItem(bool removeItem){
        if(removeItem){
            foodEquip.EquipFoodItem(-1);
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            foodValue = -1;
        }else{
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
        dragging = false;
        Cursor.SetCursor(mouse, Vector2.zero, CursorMode.ForceSoftware);
    }
    public void UseInventoryItem(){
        if(foodValue > -1 && dragging){
            if(foodValue == 2){
                foodEquip.foodUsed[2] = true;
                goodBoris.SetActive(true);
                dankje.SetActive(true);
                boris.SetActive(false);
            }else{
                foodEquip.foodUsed[foodValue] = true;
                room.SetActive(false);
                bozeBoris.SetActive(true);
            }
            ResetInventoryItem(true);
            restart.SetActive(true);
        }
    }
    public void interTrue(){
        hoverOverInteractable = true;
    }
    public void interFalse(){
        hoverOverInteractable = false;
    }


    void Update(){
        if(dragging){
            if(Input.GetMouseButtonDown(0)){
                if(hoverOverInteractable == false){
                    ResetInventoryItem(false);
                }
            }
        }
    }
}
