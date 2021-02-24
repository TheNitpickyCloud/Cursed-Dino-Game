using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class BgChange : MonoBehaviour
{
    public SpriteRenderer sunny;
    public SpriteRenderer night;
    public Animator nighty;
    public Animator sunn;
    public TMP_Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((ScoreAdd.score/3) % 15 == 0 && (ScoreAdd.score/3) % 30 != 0)
        {
            //Color col = sunny.color;
            //col.a = 0f;
            //sunny.color = col;
            //sunny.color = Color.Lerp(sunny.color, col, 1);

            //Color col2 = night.color;
            //col.a = 1f;
            //sunny.color = col;
            //sunny.color = Color.Lerp(sunny.color, col2, 1);
            sunn.SetBool("sunny", false);
            nighty.SetBool("sunny", false);
            score.color = new Color32(255, 255, 255, 255);
        }

        if((ScoreAdd.score/3) % 15 == 0 && (ScoreAdd.score/3) % 30 == 0)
        {
            //Color col = sunny.color;
            //col.a = 0f;
            //sunny.color = col;
            //sunny.color = Color.Lerp(sunny.color, col, 1);

            //Color col2 = night.color;
            //col.a = 1f;
            //sunny.color = col;
            //sunny.color = Color.Lerp(sunny.color, col2, 1);

            sunn.SetBool("sunny", true);
            nighty.SetBool("sunny", true);
            score.color = new Color32(0, 0, 0, 255);
        }
    }
}
