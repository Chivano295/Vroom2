using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class AppStartManager : MonoBehaviour
{
    void Awake()
    {
        Camera.main.backgroundColor = Color.black;
    }
    public void LoadMenu(string String)
    {
        Debug.Log("Starting menu");
        SceneManager.LoadScene(String, LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}