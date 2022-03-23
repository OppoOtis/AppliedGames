using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckGreet : MonoBehaviour
{
    [SerializeField] GreetStateManager states;

    [SerializeField] GameObject sadGreetSprite;
    [SerializeField] GameObject happyGreetSprite;

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    public void MonClicked()
    {
        states.currentState = GreetStateManager.GreetStatesEnum.mon;
        
    }

    public void TueClicked()
    {
        states.currentState = GreetStateManager.GreetStatesEnum.tue;
    }

    public void WedClicked()
    {
        states.currentState = GreetStateManager.GreetStatesEnum.wed;
    }

    public void ThurClicked()
    {
        states.currentState = GreetStateManager.GreetStatesEnum.thur;
    }

    public void Confirm()
    {
        if (states.currentState == GreetStateManager.GreetStatesEnum.thur)
        {
            HappyGreet();
        }
        else
        {
            SadGreet();
        }
    }

    public void SadGreet()
    {
        happyGreetSprite.SetActive(false);
        sadGreetSprite.SetActive(true);

    }
    public void HappyGreet()
    {
        sadGreetSprite.SetActive(false);
        happyGreetSprite.SetActive(true);
    }

    
}
