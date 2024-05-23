using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatut : MonoBehaviour
{
    public bool retweetMob;
    public int enemyScore;
   
    public IEnumerator Destruction()
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerHealth.Instance.currentHealth -= 1;
        }
    }
}
