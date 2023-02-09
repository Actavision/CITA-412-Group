using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(3);
    }
    public void LoadMain()
    {
    SceneManager.LoadScene(0);
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene(2);
    }
    public void LoadOptions()
    {
        SceneManager.LoadScene(1);
    }

}
