using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject RATIO;
    public float speed;
    public Transform newPos;
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



        if (collision.CompareTag("Enemy") && collision.GetComponent<EnemyStatut>().retweetMob && tag == "BadBullet")
        {
            newPos = collision.transform;

            Instantiate(RATIO, newPos);
            score.instance.currentScore += collision.GetComponent<EnemyStatut>().enemyScore;
            score.instance.UpdateScoreText();
            Destroy(gameObject);
            collision.GetComponent<EnemyStatut>().isDead = true;
            collision.GetComponent<BoxCollider2D>().enabled = false;
            collision.GetComponent<SpriteRenderer>().enabled = false;
        }
        else if (collision.CompareTag("Enemy") && !collision.GetComponent<EnemyStatut>().retweetMob && tag == "GoodBullet")
        {
            newPos = collision.transform;

            Instantiate(RATIO, newPos);
            score.instance.currentScore += collision.GetComponent<EnemyStatut>().enemyScore;
            score.instance.UpdateScoreText();
            Destroy(gameObject);
            collision.GetComponent<EnemyStatut>().isDead = true;
            collision.GetComponent<BoxCollider2D>().enabled = false;
            collision.GetComponent<SpriteRenderer>().enabled = false;
        }
        else return;


    }
}
