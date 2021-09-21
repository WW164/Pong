using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void start()
    {

        SceneManager.LoadScene("Game");
        
    }

    public void credit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void quit()
    {

        Application.Quit();

    }


}
