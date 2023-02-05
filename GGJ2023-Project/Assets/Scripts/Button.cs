using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void Play(){
        SceneManager.LoadScene(1);
    }

    public void Credits()
    {

    }

    public void Quit()
    {
        Application.Quit();
    }
}

