using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class Menu : MonoBehaviour
{
    public GameObject dedPanel;
    public GameObject pausePanel;
    public TMP_Text highScore;
    int checker;
    //public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        dedPanel.SetActive(false);
        pausePanel.SetActive(false);
        Time.timeScale = 1f;
        ScoreAdd.score = 0;
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Resume()
    {
        //dedPanel.SetActive(false);
        pausePanel.SetActive(false);
    	Time.timeScale = 1f;
    }
    public void Pause()
    {
        pausePanel.SetActive(true);
    	Time.timeScale = 0f;
    }

    public void Quit() 
    {
        Application.Quit();
    }

}
