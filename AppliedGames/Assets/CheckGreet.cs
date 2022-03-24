using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckGreet : MonoBehaviour
{
    [SerializeField] GreetStateManager states;
    [SerializeField] GreetHatStateManager hatStates;
 
    [SerializeField] GameObject sadGreetSprite;
    [SerializeField] GameObject happyGreetSprite;

    [SerializeField] AudioSource win;
    [SerializeField] AudioSource wrong;

    [SerializeField] float timeToGoBack = 1;
    [SerializeField] float goToNextPuzzle = 1;

    [SerializeField] GameObject[] clothes;
    [SerializeField] GameObject[] wardrobeC;
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

    public void ThurHatClicked()
    {
        hatStates.currentState = GreetHatStateManager.GreetStatesEnum.thurHat;
    }

    public void WedHatClicked()
    {
        hatStates.currentState = GreetHatStateManager.GreetStatesEnum.wedHat;
    }

    public void TueHatClicked()
    {
        hatStates.currentState = GreetHatStateManager.GreetStatesEnum.tueHat;
    }

    public void MonHatClicked()
    {
        hatStates.currentState = GreetHatStateManager.GreetStatesEnum.monHat;
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
        if (states.currentState == GreetStateManager.GreetStatesEnum.thur && hatStates.currentState == GreetHatStateManager.GreetStatesEnum.thurHat)
        {
            HappyGreet();
            win.Play();
            StartCoroutine(NextScene());
        }
        else
        {
            SadGreet();
            wrong.Play();
            StartCoroutine(GoBack());
        }
    }

    IEnumerator GoBack()
    {
        yield return new WaitForSeconds(timeToGoBack);
        RegularGreet();
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(goToNextPuzzle);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RegularGreet()
    {
        happyGreetSprite.SetActive(false);
        sadGreetSprite.SetActive(false);
        foreach (GameObject item in clothes)
        {
            item.SetActive(false);
        }

        foreach (GameObject item in wardrobeC)
        {
            item.SetActive(true);
        }
        StopCoroutine(GoBack());
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
