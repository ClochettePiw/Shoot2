using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShip : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        CheckInput();
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

        if (Input.GetKey (KeyCode.Space))
        {
            Shoot();
        }
    }

    public void Move(float move)
    {
        rb.velocity = new Vector2(move * Time.deltaTime, 0);
    }

    public void Shoot()
    {

    }

}
