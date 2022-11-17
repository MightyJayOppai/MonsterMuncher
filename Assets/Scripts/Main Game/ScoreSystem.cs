using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int score;   

    void Update()
    {
        scoreText.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
