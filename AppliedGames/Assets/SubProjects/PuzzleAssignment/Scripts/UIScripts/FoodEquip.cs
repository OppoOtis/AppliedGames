using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FoodEquip : MonoBehaviour
{
    public Sprite[] foodImages;
    public GameObject[] foodItems;
    public int foodValue;
    public bool[] foodUsed = {
        false,false,false,false,false,false
    };

    public void EquipFoodItem(int value){
        foodValue = value;
        if(value == -1){
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }else{
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite = foodImages[value];
            for(int i = 0; i < foodItems.Length; i++){
                if(foodUsed[i] == false){
                    foodItems[i].SetActive(true);
                }else{
                    foodItems[i].SetActive(false);
                }
            }
            foodItems[value].SetActive(false);
        }
    }
}
