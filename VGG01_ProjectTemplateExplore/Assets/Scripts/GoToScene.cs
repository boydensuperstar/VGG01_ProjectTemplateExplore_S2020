using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// since we are using scene management, we need to add the UnityEngine Scenemanagement class
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour
{
    //This is a public variable allowing you to type the name of the scene in the component instead of putting it in the script
    public string SceneName;

    // Once the character touches the collider, the character will load the new scene
    private void OnTriggerEnter(Collider other)
    {
        // In the console, it will appear that the character hit the trigger saying that the character entered the public variable string name
        Debug.Log("Entered " + SceneName);
        // Which scene to load based upon the public variable above
        SceneManager.LoadScene(SceneName);
    }
}
