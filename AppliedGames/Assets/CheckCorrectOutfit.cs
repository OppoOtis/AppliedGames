using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CheckCorrectOutfit : MonoBehaviour
{
    [SerializeField] BorisStateManager states;
    [SerializeField] BorisHatStateManager hatStates;
    

    [SerializeField] GameObject sadBorisSprite;
    [SerializeField] GameObject happyBorisSprite;

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

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }

    public void MonClicked()
    {
        hatStates.currentState = BorisHatStateManager.BorisStatesEnum.mon;
    }

    public void TueClicked()
    {
        hatStates.currentState = BorisHatStateManager.BorisStatesEnum.tue;
    }

    public void WedClicked()
    {
        hatStates.currentState = BorisHatStateManager.BorisStatesEnum.wed;
    }

    public void ThurClicked()
    {
        hatStates.currentState = BorisHatStateManager.BorisStatesEnum.thur;
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
        if(states.currentState == BorisStateManager.BorisStatesEnum.red && hatStates.currentState == BorisHatStateManager.BorisStatesEnum.thur)
        {
            HappyBoris();
            win.Play();
            StartCoroutine(NextScene());
        }
        else
        {
            SadBoris();
            wrong.Play();
            
            StartCoroutine(GoBack());
        }
    }

    IEnumerator GoBack()
    {
        yield return new WaitForSeconds(timeToGoBack);
        RegularBoris();
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSeconds(goToNextPuzzle);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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

    public void RegularBoris()
    {
        sadBorisSprite.SetActive(false);
        happyBorisSprite.SetActive(false);
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
    
}
