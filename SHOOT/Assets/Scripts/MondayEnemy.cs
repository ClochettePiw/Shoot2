using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class MondayEnemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Moving();
    }

    public void Moving()
    {
        rb.velocity = new Vector2(0, speed * Time.deltaTime);
    }
}
