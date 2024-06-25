using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{

    public static bool gameIsPaused;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    public void Start() {
        gameIsPaused = false;
        pauseMenu.SetActive(false);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            if (gameIsPaused)
                PauseGame();
            else ResumeGame();
        }
    }

    public void ResumeGame() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

}
