using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int ScoreBase = 0;
    public int currentScore;
    public TMPro.TextMeshProUGUI scoreText;

    void Start()
    {
        currentScore = ScoreBase;
        UpdateScoreText();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            GainScore();
        }
    }

    void GainScore()
    {
        currentScore++;
        Debug.Log("Score augmenté à: " + currentScore);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }
}