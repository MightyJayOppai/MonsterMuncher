using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void RegisterUser()
    {
        SceneManager.LoadScene(1);
    }
    public void LoginUser()
    {
        SceneManager.LoadScene(2);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(4);
    }

    public void MultiplayerMenu()
    {
        SceneManager.LoadScene(3);
    }
    public void PlayMultiplayer()
    {
        SceneManager.LoadScene(5);
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
