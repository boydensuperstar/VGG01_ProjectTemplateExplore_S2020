using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneyMana : MonoBehaviour
{
    // Start is called before the first frame update
    public static int ThisScene;

    void Awake()
    {
        ThisScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("The current scene is " + ThisScene);
    }

    private void Start()
    {
        GameObject check = GameObject.Find("__app");
        if (check == null)
        {
            SceneManager.LoadScene("_Preload");
        }

    }


}
