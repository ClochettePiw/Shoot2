using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static score instance;
    public int ScoreBase = 0;
    public int currentScore;
    public TMPro.TextMeshProUGUI scoreText;

    void Start()
    {
        instance = this;
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

    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }
}