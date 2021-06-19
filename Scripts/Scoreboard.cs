using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    [SerializeField] Text scoreboard;
    [SerializeField] ScoreManager scoreManager;

    // Update is called once per frame
    void Update()
    {
        scoreManager.ShowScore(scoreboard);
    }
}
