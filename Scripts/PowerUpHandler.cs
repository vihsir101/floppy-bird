using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpHandler : MonoBehaviour
{
    [SerializeField] Scorer scorer;
    [SerializeField] Player Player;
    [SerializeField] Camera myCamera;
    [SerializeField] GameObject[] PowerUps;
    [SerializeField] PowerUp powerUp;
    [SerializeField] float speed = 100f;
    [SerializeField] GameObject PowerupBar;
    Rigidbody Myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Myrigidbody = GetComponent<Rigidbody>();
        Myrigidbody.AddForce(Vector3.left * -speed);
        PowerupBar.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {

        if (gameObject.tag == PowerUps[1].tag & other.tag == Player.tag)
        {
            PowerupBar.SetActive(true);
            scorer.points = scorer.points * 2;
            powerUp.time = 0;
            Destroy(gameObject);
        }
        if (gameObject.tag == PowerUps[0].tag & other.tag == Player.tag)
        {
            PowerupBar.SetActive(true);
            myCamera.fieldOfView = 100f;
            Player.birdState = "immortal";
            powerUp.time = 0;
            Destroy(gameObject);
        }

        if (gameObject.tag == PowerUps[2].tag & other.tag == Player.tag)
        {
            PowerupBar.SetActive(true);
            Player.birdState = "immortal";
            powerUp.time = 0;
            Destroy(gameObject);
        }
    }
    void Update()
    {
        if (powerUp.time >= 19)
        {
            PowerupBar.SetActive(false);
            scorer.points = 10;
            myCamera.fieldOfView = 60f;
            Player.birdState = "mortal";
        }
    }
}
