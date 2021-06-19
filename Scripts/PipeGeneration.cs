using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGeneration : MonoBehaviour
{
    [SerializeField] int minHeight = 0;
    [SerializeField] int maxHeight = 100;
    [SerializeField] GameObject Pipe;
    [SerializeField] public GameObject PipeGen;
    private float time = 0;
    public int height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(Pipe);
        height = Random.Range(minHeight, maxHeight);
        newPipe.transform.position = new Vector3(PipeGen.transform.position.x, height, PipeGen.transform.position.z);
        Destroy(newPipe, 9f);
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 5f)
        {
            CreatePipe();
        }

        time += Time.deltaTime;
    }

    private void CreatePipe()
    {
        GameObject newPipe = Instantiate(Pipe);
        height = Random.Range(minHeight, maxHeight);
        newPipe.transform.position = new Vector3(PipeGen.transform.position.x, height, PipeGen.transform.position.z);
        Destroy(newPipe, 9f);
        time = 0;

    }
}
