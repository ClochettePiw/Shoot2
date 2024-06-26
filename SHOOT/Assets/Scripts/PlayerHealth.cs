using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static PlayerHealth Instance;
    public int maxHealth = 5;
    public int currentHealth;

    void Start()
    {
        Instance = this;
        currentHealth = maxHealth;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            GainHealth();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            LoseHealth();
        }
    }

    void GainHealth()
    {
            currentHealth++;
            Debug.Log("Vie augment� �: " + currentHealth);
    }

    void LoseHealth()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            Debug.Log("Vie r�duite �: " + currentHealth);
        }
    }
}