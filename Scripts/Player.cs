using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] float jumpForce = 15f;
    Rigidbody Myrigidbody;
    [SerializeField] GameObject Pipe;
    [SerializeField] GameObject Ground;
    public string birdState;

    [SerializeField] GameManagment gameManagment;
    // Start is called before the first frame update
    void Start()
    {
        birdState = "mortal";
        Myrigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (birdState != "immortal")
        {
            if (other.tag == Pipe.tag)
            {
                gameManagment.StopGame();
            }
        }
        if (other.tag == Ground.tag)
        {
            gameManagment.StopGame();
        }
    }

    void Jump()
    {
        Myrigidbody.velocity = new Vector3(0, jumpForce, 0);
    }


}
