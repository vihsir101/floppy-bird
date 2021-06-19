using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Xbutton : MonoBehaviour
{
    // Start is called before the first frame update
    Button startButton;
    void Start()
    {
        startButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        startButton.onClick.AddListener(ExitGame);
    }

    void ExitGame()
    {
        Application.Quit();
    }
}
