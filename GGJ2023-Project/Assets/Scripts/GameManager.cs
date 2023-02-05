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
    int clearScore = 0;
    public Text scoreText;
    public TextMeshProUGUI scoreNumEnd;
    public GameObject gameoverPanel;
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {

        PlayerPrefs.SetInt("curScore", clearScore);
        Time.timeScale = 1;
        AudioListener.pause = false;
        gameEnd = core.GetComponent<Core>().end;
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerPrefs.GetInt("curScore");
        scoreText.text = score.ToString();
        scoreNumEnd.text = score.ToString();
        
    }

    public void MainMenu(){
        
        SceneManager.LoadScene("Menu");

    }
    public void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}


