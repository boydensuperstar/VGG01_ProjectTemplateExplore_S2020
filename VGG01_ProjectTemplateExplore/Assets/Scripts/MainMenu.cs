using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// since we are changing scenes, we need scene management
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    // on hitting play game it will load the next scene in the build.  If the lobby is not the next scene, it will load whatever scene is after the main menu
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // on hitting quit, it will quit the game
    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}