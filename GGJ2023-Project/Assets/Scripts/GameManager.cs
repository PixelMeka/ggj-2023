using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject clickButton;

    public GameObject player;

    bool gameEnd = false;
    public bool paused = false;

    public GameObject core;

    int score;
    public Text scoreText;
    public GameObject gameoverPanel;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        gameEnd = core.GetComponent<Core>().end;
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerPrefs.GetInt("curScore");
        scoreText.text = score.ToString();

        
    }

    public void MainMenu(){
        
        SceneManager.LoadScene("Menu");

    }
    public void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}


