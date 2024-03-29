﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlayButton : MonoBehaviour
{


    bool loadingInitiated = false;
    

    // I am expanding this class to also handle the buttons in level select. PlayButtonPressed() may be changed in the future once save data is implemented
    public void PlayButtonPressed()
    {
        // straighforward fix for it not doing anything. we can come back later and choose a different solution
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //If statement is to ensure DelayedLoad() runs only once
        if (!loadingInitiated)
        {

            StartCoroutine(DelayedLoad());
            loadingInitiated = true;

        }

        
    }

    public void playLevelFromLevelSelectScreen()
    {
        SceneManager.LoadScene(int.Parse(gameObject.tag));
    }

    public void QuitGame()
    {
        Debug.Log("Quit Button Pressed");
        Application.Quit();
    }

    public void BootlegVictoryMainMenuButton()
    {
        SceneManager.LoadScene(0);
    }


    IEnumerator DelayedLoad()
    {
        yield return new WaitForSeconds(1.0f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
