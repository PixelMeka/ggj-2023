using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnd = false;

    public GameObject core;

    public GameObject gameoverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameEnd = core.GetComponent<Core>().end;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MainMenu(){
        
        SceneManager.LoadScene("Menu");

    }
    public void Restart(){
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
