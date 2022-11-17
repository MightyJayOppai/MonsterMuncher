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
    public void StartGame()
    {
        SceneManager.LoadScene("SinglePlayer Game");
    }

    public void Retry()
    {
        SceneManager.LoadScene("Singleplayer Main Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
