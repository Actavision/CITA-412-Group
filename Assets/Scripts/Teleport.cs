using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(currentScene + 1);
        }
    }
}
