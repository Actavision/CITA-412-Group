using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SoundScript : MonoBehaviour
{
    private int currentScene;
    private static SoundScript instance = null;
    public static SoundScript Instance
    {
        get { return instance; }
    }
    private void Update()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if (currentScene == 7 || currentScene == 0)
        {
            Destroy(this.gameObject);
            return;
        }
        else { DontDestroyOnLoad(this.gameObject); }
    }
    void Awake()
    {
        if (currentScene == 7)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
        
    }
}