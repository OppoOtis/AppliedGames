using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSelectionPuzzle3 : MonoBehaviour
{
    public bool greet;
    public bool[] checkColor = {false,true,false,false,true,false,false,false,true};
    public bool[] checkSymbol = {true,false,false,false,false,true,true};

    public bool[] color = {false,false,false,false,false,false,false,false,false};
    public bool[] symbol = {false,false,false,false,false,false,false};

    public void UpdateCheck(int boolUpdateValue){
        int counter = 0;
        if(greet){
            color[boolUpdateValue] = !color[boolUpdateValue];
            for (int i = 0; i < checkColor.Length; i++)
            {
                if(checkColor[i] != color[i]){
                    counter++;
                }
            }
        }else{
            symbol[boolUpdateValue] = !symbol[boolUpdateValue];
            for (int i = 0; i < checkSymbol.Length; i++)
            {
                if(checkSymbol[i] != symbol[i]){
                    counter++;
                }
            }
        }
        if(counter == 0){
            SceneManager.LoadScene(0);
        }
    }
}
