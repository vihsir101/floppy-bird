using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PowerUp : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Power;
    [SerializeField] GameObject[] PowerUps;

    [SerializeField] public float time = 0;
    GameObject newPower;
    GameObject Powerup;
    [SerializeField] PipeGeneration pipeGeneration;
    [SerializeField] int chancesOfPowerupSpawning = 25;
    private void CreatePower()
    {
        Powerup = PowerUps[Random.Range(0, 3)];
        newPower = Instantiate(Powerup);
        newPower.transform.position = new Vector3(Power.transform.position.x + 5, pipeGeneration.height, Power.transform.position.z);
        Destroy(newPower, 9f);
        time = 0;

    }




    void Update()
    {
        if (time > 19)
        {
            int chance = Random.Range(0, 100);
            if (chance > 100 - chancesOfPowerupSpawning)
            {
                CreatePower();
            }
            else
            {
                time = 0;
            }
        }

        time += Time.deltaTime;
    }

}

