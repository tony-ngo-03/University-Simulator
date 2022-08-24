using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlScript : MonoBehaviour
{
    public GameObject resumeButton;
    public GameObject quitButton;
    public GameObject text;
    public GameObject worldCamera;
    private bool isPaused;
    public void playGame()
    {
        SceneManager.LoadScene("Introduction");
    }

    public void testGame()
    {
        SceneManager.LoadScene("TestCustomCharacter");
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void pauseGame()
    {
        Time.timeScale = 0.0f;
        resumeButton.SetActive(true);
        quitButton.SetActive(true);
        text.SetActive(true);
    }

    void Update()
    {
        if (!SceneManager.GetActiveScene().name.Equals("Menu")){
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                gameObject.transform.position = worldCamera.transform.position;
                if (isPaused)
                {
                    isPaused = false;
                    resumeGame();
                }
                else
                {
                    isPaused = true;
                    pauseGame();
                }
            }
        }
    }

    public void resumeGame()
    {
        Time.timeScale = 1.0f;
        text.SetActive(false);
        quitButton.SetActive(false);
        resumeButton.SetActive(false);
    }
}
