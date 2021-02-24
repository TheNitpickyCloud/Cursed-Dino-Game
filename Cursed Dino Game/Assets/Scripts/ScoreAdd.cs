using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreAdd : MonoBehaviour
{
    public static int score;
    public TMP_Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        scoreText.text = (score/3).ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            score += 1;
            
        }
    }
}
