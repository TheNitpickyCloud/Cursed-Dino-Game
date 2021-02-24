using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCactus : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;
    public GameObject cactus3;
    public float time = 2;
    float buffer;
    public Vector3 spawnPoint = new Vector3(10.55f, -2.75f, -1f);
    // Start is called before the first frame update
    void Start()
    {
        buffer = time;
    }

    // Update is called once per frame
    void Update()
    {
        if(buffer <= 0)
        {
            time -= 0.05f;
            int num = Random.Range(0, 3);
            if(num == 0)
            {
                Instantiate(cactus1, spawnPoint, Quaternion.identity);
            }

            if(num == 1)
            {
                Instantiate(cactus2, spawnPoint, Quaternion.identity);
            }

            if(num == 2)
            {
                Instantiate(cactus3, spawnPoint, Quaternion.identity);
            }

            buffer = time;
        }

        else
        {
            buffer -= Time.deltaTime;
        }
    }
}
