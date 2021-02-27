using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // I am expanding this class to also handle the buttons in level select. PlayButtonPressed() may be changed in the future once save data is implemented
    public void PlayButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void playLevelFromLevelSelectScreen()
    {
        SceneManager.LoadScene(int.Parse(gameObject.tag));
    }
}
