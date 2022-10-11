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
    public void LoadMenu()
    {
        Debug.Log("Starting menu");
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}