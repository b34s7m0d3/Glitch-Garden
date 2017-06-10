using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    public float autoLoadNextLevelAfter;

    void Start()
    {
        if (autoLoadNextLevelAfter == 0)
        {
            //Debug.Log("level loaded");
        } else Invoke("LoadNextLevel", autoLoadNextLevelAfter);
    }

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
      //  Application.LoadLevel(name);
		SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("I want to quit");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(Application.loadedLevel + 1);
    }

}