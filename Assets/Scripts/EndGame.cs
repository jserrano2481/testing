using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    private void Start()
    {
        Invoke("GameOver", 4f);
    }

    public void GameOver()
    {
        // end the game
        SceneManager.LoadScene("MainMenu");
    }
}
