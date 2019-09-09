using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "Username and Score")]
public class ScoreObj : ScriptableObject
{
    public string userName;
    public string playerScore;
}
