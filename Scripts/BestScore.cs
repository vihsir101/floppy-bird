using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BestScore : MonoBehaviour
{
    [SerializeField] Text scoreboard;
    [SerializeField] ScoreManager scoreManager;

    // Update is called once per frame
    void Update()
    {
        scoreManager.ShowBestScore(scoreboard);
    }
}
