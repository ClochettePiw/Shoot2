using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    void Start()
    {
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
            Debug.Log("Vie augmenté à: " + currentHealth);
    }

    void LoseHealth()
    {
        if (currentHealth > 0)
        {
            currentHealth--;
            Debug.Log("Vie réduite à: " + currentHealth);
        }
    }
}