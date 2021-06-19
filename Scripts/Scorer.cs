using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] GameObject Player;
    [SerializeField] public int points = 1;
    [SerializeField] ScoreManager scoreManager;
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == Player.tag)
        {
            scoreManager.AddPoints(points);
        }
    }
}
