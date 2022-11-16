using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public static AddScore instance = null;

    //private string addScoreURL = "http://localhost/monstermuncher/addScore.php";
    private string addScoreURL = "https://monstermuncher.000webhostapp.com/addScore.php";
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UploadScore(string score)
    {
        WWWForm scoreForm = new WWWForm();
        Debug.LogWarning("WWWForm Created"); //Testing

        //scoreForm.AddField("playerUsername", playerName);
        scoreForm.AddField("userScore", score);
        Debug.LogWarning("UserScore Field Added"); //Testing

        WWW dbLink = new WWW(addScoreURL, scoreForm);
        Debug.LogWarning("Databse Accessed"); //Testing
    }
}
