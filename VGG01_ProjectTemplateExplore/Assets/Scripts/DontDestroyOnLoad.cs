using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyOnLoad : MonoBehaviour
{
    private static int SameScene;
  
    public void Awake()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Don't Destroy on Load " + gameObject.name);
    }

    public void Start()
    {

        SameScene = SceneManager.GetActiveScene().buildIndex;

        int ThisScene = SceneyMana.ThisScene;

        Debug.Log("ThisScene is " + ThisScene);
        Debug.Log("SameScene is " + SameScene);

        if (ThisScene == SameScene)
        {
            SceneManager.LoadScene("MainMenu");

        }
        else
        {
            SceneManager.LoadScene(ThisScene);
        }
    }

}

