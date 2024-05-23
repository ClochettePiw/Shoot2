using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.transform.SetParent(null);
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    public void Moving()
    {
        rb.velocity = new Vector2(0, -speed * Time.deltaTime);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Wall")) Destroy(gameObject);

        if (collision.CompareTag("Enemy") && collision.GetComponent<MondayEnemy>().retweetMob)
        {
            Destroy(collision.gameObject);
            score.instance.currentScore += 10;
            score.instance.UpdateScoreText();
        }
            
            
    }
}
