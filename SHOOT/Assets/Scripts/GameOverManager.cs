using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverMenu;
    private PlayerHealth playerHealth;
    public TMPro.TextMeshProUGUI FinalScoreText;

    void Start()
    {
        playerHealth = FindObjectOfType<PlayerHealth>();
        gameOverMenu.SetActive(false);
    }

    void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            gameOverMenu.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Home()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }

    void TheFinalScoreText()
    {
        //ScoreText.text = "Score Final: " + currentScore.ToString();
    }
}
