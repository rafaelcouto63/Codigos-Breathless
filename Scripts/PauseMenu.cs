using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject Palyer;

    public PlayerCheckPoint playerCheckPoint;

    private Vector3 CheckPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();

            } else {

                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Restart()
    {
       CheckPoint = playerCheckPoint.ultimoCheckpoint;
       Palyer.transform.position = CheckPoint;
       pauseMenuUI.SetActive(false);
       Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
