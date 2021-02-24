using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cactus_death : MonoBehaviour
{
    public GameObject dedPanel;
    public float speed;

    float buffer;

    float time = 10f;
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
            speed += 0.25f;
            
            buffer = time;
        }

        else
        {
            buffer -= Time.deltaTime;
        }

        transform.position = Vector3.MoveTowards(transform.position, new Vector3(-11f, -2.75f, -1f), speed*Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D info)
    {
        if(info.CompareTag("Player"))
        {
            Time.timeScale = 0f;
            dedPanel.SetActive(true);
        }
    }
}
