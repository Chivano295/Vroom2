using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string scene;
    public void ChangeScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
