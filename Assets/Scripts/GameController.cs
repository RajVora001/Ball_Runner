using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject gameOverpanel;
    private void Start()
    {
        gameObject.SetActive(false);
      
    }

   


    public void GameOver()
    {
        gameOverpanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
  
}
