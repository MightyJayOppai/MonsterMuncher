using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    public float currentTime;
    public float startingTime;
    public ScoreObj scoring;
    
    [SerializeField]
    Text timerCountDownText;
    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        timerCountDownText.text = currentTime.ToString("0");

        if(currentTime < 0)
        {
            currentTime = 0;
            scoring.playerScore = ScoreSystem.score.ToString();
            SceneManager.LoadScene("Game Over");
            ScoreReset();
        }
    }
    public void ScoreReset()
    {
        ScoreSystem.score = 0;
    }
}
