using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public static bool isPaused = false;
    public GameObject pauseMenuUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void settingsButton()
    {
        Debug.Log("Settings button pressed");
    }

    public void returnToMainMenu()
    {
        // scene zero is always the main menu. if it's not, then the first thing to load is
        // not going to be the main menu, and thats a problem that comes before this line of
        // code not working. check this in build settings in unity editor
        Debug.Log("loading main menu");
        SceneManager.LoadScene(0);
    }
}
