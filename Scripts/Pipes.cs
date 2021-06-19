using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    [SerializeField] float speed = 100f;
    Rigidbody Myrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Myrigidbody = GetComponent<Rigidbody>();
        Myrigidbody.AddForce(Vector3.left * -speed);
    }

    // Update is called once per frame
}
