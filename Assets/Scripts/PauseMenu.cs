using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        PauseControl.gameIsPaused = false;
    }

    public void Restart()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void QuitGame() {
        Application.Quit();
    }
}
