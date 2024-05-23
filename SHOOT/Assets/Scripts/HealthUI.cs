using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public static HealthUI instance;
    public Sprite fullHeart;
    public Sprite emptyHeart;
    public Image[] hearts;
    public TMPro.TextMeshProUGUI extraLivesText;

    private PlayerHealth playerHealth;

    void Start()
    {
        instance = this;
        playerHealth = FindObjectOfType<PlayerHealth>();
        UpdateHearts();
    }

    void Update()
    {
        UpdateHearts();
    }

    void UpdateHearts()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < playerHealth.currentHealth && i < playerHealth.maxHealth)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
        }

        if (playerHealth.currentHealth > playerHealth.maxHealth)
        {
            extraLivesText.text = "+" + (playerHealth.currentHealth - playerHealth.maxHealth).ToString();
            extraLivesText.enabled = true;
        }
        else
        {
            extraLivesText.enabled = false;
        }
    }
}