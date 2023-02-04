using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject clickButton;

    bool gameEnd = false;
    bool paused = false;

    public GameObject core;

    int score;
    public Text scoreText;
    public GameObject gameoverPanel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameEnd = core.GetComponent<Core>().end;
    }

    // Update is called once per frame
    void Update()
    {
        score = PlayerPrefs.GetInt("curScore");
        scoreText.text = score.ToString();

        if(gameEnd == false){

            if (Input.GetKeyDown(KeyCode.Escape) && !paused){

            Time.timeScale = 0;
            

            }
  
        }

        
    }

    public void MainMenu(){
        
        SceneManager.LoadScene("Menu");

    }
    public void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}


