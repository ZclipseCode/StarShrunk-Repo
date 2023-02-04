using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKnockback : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float knockback;
    bool enemyCol = false;
    bool contactRight;
    [SerializeField] float kbTime;
    float timer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (enemyCol)
        {
            timer += Time.deltaTime;

            if (contactRight)
            {
                rb.velocity = new Vector2(-knockback, knockback);
            }
            else
            {
                rb.velocity = new Vector2(knockback, knockback);
            }

            if (timer >= kbTime)
            {
                enemyCol = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyCol = true;

            if (collision.gameObject.transform.position.x >= transform.position.x)
            {
                contactRight = true;
            }
            else
            {
                contactRight = false;
            }
        }
    }
}
