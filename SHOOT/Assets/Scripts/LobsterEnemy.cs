using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobsterEnemy : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public int waitingTime;
    public bool isAttacking;
    public bool isDodging;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (!isDodging) Dodging();
        if (isAttacking) Moving();
    }

    public void Dodging()
    {
        isDodging = true;
        Debug.Log("attaque");
        StartCoroutine(MovementCoroutine());
    }

    IEnumerator MovementCoroutine()
    {
        rb.velocity = new Vector2(15, 0);
        yield return new WaitForSeconds(waitingTime);
        rb.velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(waitingTime * 0.5f);

        rb.velocity = new Vector2(-15, 0);
        yield return new WaitForSeconds(waitingTime);
        rb.velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(waitingTime * 0.5f);

        rb.velocity = new Vector2(15, 0);
        yield return new WaitForSeconds(waitingTime);
        rb.velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(waitingTime * 0.5f);

        rb.velocity = new Vector2(-15, 0);
        yield return new WaitForSeconds(waitingTime);
        rb.velocity = new Vector2(0, 0);
        yield return new WaitForSeconds(waitingTime * 0.5f);
        isAttacking = true;
    }

    public void Moving()
    {
        rb.velocity = new Vector2(0, 10);
        Debug.Log("attaque finale");
    }
}
