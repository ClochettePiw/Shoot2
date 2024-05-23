using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathEnemy : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public bool canShoot;
    public Transform newPos;
    public GameObject bullet;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Moving();
        if (canShoot && !GetComponent<EnemyStatut>().isDead) StartCoroutine(Shoot());
    }

    public void Moving()
    {
        rb.velocity = new Vector2(5, 0);
    }

    public IEnumerator Shoot()
    {
        canShoot = false;
        Instantiate(bullet, newPos);
        Debug.Log("shoot");
        yield return new WaitForSeconds(1);
        canShoot = true;
    }
}
