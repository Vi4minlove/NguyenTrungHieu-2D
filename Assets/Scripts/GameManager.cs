using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject gamePauseUI;

    private void Start()
    {
        Time.timeScale = 1;
        AudioManager.instance.Play("Background");
    }
    private void Update()
    {
        
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }
    public void pauseGame()
    {
        gamePauseUI.SetActive(true);
        Time.timeScale = 0;
    }
    public void resumeGame()
    {
        gamePauseUI.SetActive(false);
        Time.timeScale = 1;
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        CoinCounter.currentCoins = 0;
    }
    public void homeMenu()
    {
        SceneManager.LoadScene("MainMenu");
        CoinCounter.currentCoins = 0;
    }
    public void rate()
    {
        SceneManager.LoadScene("Rate");
        Debug.Log("Rate");
    }
}
