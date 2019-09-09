using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserInfo : MonoBehaviour
{
    #region Public Variables
    public InputField showUserField;
    public Text showScoreField;
    //public UsernameObj user;
    public ScoreObj scoring;
    
    [SerializeField]
    private bool scoreUploaded;
    #endregion
    #region Private Variables
    // private string addScoreURL = "http://localhost/monstermuncher/addScore.php"; //XAMPP Database
    private string addScoreURL = "https://monstermuncher.000webhostapp.com/addScore.php";
    #endregion

    #region Unity Callbacks
    void Start()
    {
        showUserField.text = scoring.userName;
        showScoreField.text = scoring.playerScore;
        scoreUploaded = false;
    }

    void Update()
    {
        
    }
    #endregion
    #region My Functions
    public void UploadScore()
    {
        if (!scoreUploaded)
        {
            StartCoroutine(ScoreStats(showUserField.text, showScoreField.text));
            scoreUploaded = true;
        }
    }

    private IEnumerator ScoreStats(string username, string playerScore)
    {
        WWWForm scoreForm = new WWWForm();
        Debug.LogWarning("WWWForm Created"); //Testing

        scoreForm.AddField("playerUsername", username);
        scoreForm.AddField("userScore", playerScore);
        Debug.LogWarning("UserScore Field Added"); //Testing

        WWW dbLink = new WWW(addScoreURL, scoreForm);
        yield return dbLink;
        /*if (dbLink.text == "Working")
            Debug.LogWarning("Score Uploaded to Database");
        else if (dbLink.text == "Error")
            Debug.LogWarning("Score Upload Failed");*/
    }
    #endregion
}
