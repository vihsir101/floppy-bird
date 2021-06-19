using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int score;
    [SerializeField] GameObject scoreManager;
    int bestScore;

    void Awake()
    {
        bestScore = PlayerPrefs.GetInt("bestScore");
    }
    public void AddPoints(int points)
    {
        score += points;
    }

    public void BestScore()
    {
        if (score > bestScore)
        {
            bestScore = score;
            PlayerPrefs.SetInt("bestScore", bestScore);
            PlayerPrefs.Save();
        }
    }

    public void ShowScore(Text scoreboard)
    {
        scoreboard.text = score.ToString();
    }

    public void ShowBestScore(Text scoreboard)
    {
        bestScore = PlayerPrefs.GetInt("bestScore");
        scoreboard.text = bestScore.ToString();
    }

}
