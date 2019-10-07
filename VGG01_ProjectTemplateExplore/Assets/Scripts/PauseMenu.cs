using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseMenu : MonoBehaviour
{
    // Public variable checking to see if game is paused, originally set to false

    public static bool GameIsPaused = false;

    // Public variable setting up the pause menu
    public GameObject PauseMenuUI;

    // public game object asking you to put in the FPSController
    public GameObject FPSController;

    // A method called on start that is finding the FPSController with a game tag of player
    private void Start()
    {
        FPSController = GameObject.FindWithTag("Player");
    }



    // Called on an update, this is stating if the escape key is pushed then pause the game or unpause the game
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();

            }
        }
    }

    // Called on resuming the game let's the first person controller be controllable and sets the timescale at normal time scale plus sets the game is paused variable to false
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        FPSController.GetComponent<FirstPersonController>().enabled = true;
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    // called on when paused, disables the controller, stops the time, and changes the pause variable to true
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        FPSController.GetComponent<FirstPersonController>().enabled = false;
        Time.timeScale = 0f;
        GameIsPaused = true;

    }

    // called if you load the menu and brings up the main menu
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    // called when you quit game telling you that it quit - in this version, there is a debug that 
    public void QuitGame()
    {
        Application.Quit();
    }

}