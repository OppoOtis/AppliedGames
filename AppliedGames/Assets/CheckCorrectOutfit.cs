using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckCorrectOutfit : MonoBehaviour
{
    [SerializeField] BorisStateManager states;
    

    [SerializeField] GameObject sadBorisSprite;
    [SerializeField] GameObject happyBorisSprite;


   
    void Update()
    {
        
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    public void redClicked()
    {
        states.currentState = BorisStateManager.BorisStatesEnum.red;
    }

    public void greenClicked()
    {
        states.currentState = BorisStateManager.BorisStatesEnum.green;
    }

    public void blueClicked()
    {
        states.currentState = BorisStateManager.BorisStatesEnum.blue;
    }

    public void yellowClicked()
    {
        states.currentState = BorisStateManager.BorisStatesEnum.yellow;
    }

    public void Confirm()
    {
        if(states.currentState == BorisStateManager.BorisStatesEnum.red)
        {
            HappyBoris();
        }
        else
        {
            SadBoris();
        }
    }

    public void SadBoris()
    {
        happyBorisSprite.SetActive(false);
        sadBorisSprite.SetActive(true);
    }

    public void HappyBoris()
    {
        sadBorisSprite.SetActive(false);
        happyBorisSprite.SetActive(true);        
    }
    
}
