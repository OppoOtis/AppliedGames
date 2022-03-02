using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodEquip : MonoBehaviour
{
    public Sprite[] foodImages;
    public GameObject[] foodItems;

    public void EquipFoodItem(int value){
        if(value == -1){
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }else{
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = foodImages[value];
            for(int i = 0; i < foodItems.Length; i++){
                foodItems[i].SetActive(true);
            }
            foodItems[value].SetActive(false);
        }
    }
}
