using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagment : MonoBehaviour
{
    [SerializeField] GameObject loseCanvas;
    [SerializeField] Button startButton;
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] GameObject PowerupBar;
    // Start is called before the first frame update
    void Start()
    {
        loseCanvas.SetActive(false);
        Time.timeScale = 2f;
    }

    public void StopGame()
    {
        PowerupBar.SetActive(false);
        scoreManager.BestScore();
        loseCanvas.SetActive(true);
        Time.timeScale = 0;
        startButton.onClick.AddListener(ResetGame);

    }

    public void ResetGame()
    {
        SceneManager.LoadScene(1);
    }

}
