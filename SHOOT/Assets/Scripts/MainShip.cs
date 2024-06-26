using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShip : MonoBehaviour
{
    public static MainShip instance;
    public Rigidbody2D rb;
    public GameObject likeBullet;
    public GameObject retweetBullet;
    public float speed;
    public float leftBorder;
    public float rightBorder;
    public Transform newPos;
    public bool canShoot = true;

    void Start()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        CheckInput();
        CheckBorder();
    }

    public void CheckInput()
    {
        float move;
        if (Input.GetKey(KeyCode.A))
        {
            move = -speed;
            Move(move);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = speed;
            Move(move);
        }
        else
        {
            move = 0;
            Move(move);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (!canShoot) return;
            else 
            {
                canShoot = false;
                LikeShoot();
                StartCoroutine(ShootTimer());
            }  
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (!canShoot) return;
            else
            {
                canShoot = false;
                RetweetShoot();
                StartCoroutine(ShootTimer());
            }
        }
    }

    IEnumerator ShootTimer()
    {
        yield return new WaitForSeconds(0.5f);

        canShoot = true;
    }
    public void CheckBorder()
    {
        if (transform.position.x < leftBorder)
        {
            transform.position = new Vector2(leftBorder, transform.position.y);
        }
        else if (transform.position.x > rightBorder)
        {
            transform.position = new Vector2(rightBorder, transform.position.y);
        }
    }

    public void Move(float move)
    {
        rb.velocity = new Vector2(move * Time.deltaTime, 0);
    }

    public void LikeShoot()
    {
        Instantiate(likeBullet, newPos);
    }
    public void RetweetShoot()
    {
        Instantiate(retweetBullet, newPos);
    }
}
