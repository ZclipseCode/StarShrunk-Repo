using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolEnemy : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] bool goesClockwise = true;
    [SerializeField] float speed;
    private float timer = 0;
    [SerializeField] float targetTime;
    //bool isGrounded;
    [SerializeField] float pull;
    //[SerializeField] float velocityLimit;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= targetTime)
        {
            if (goesClockwise)
            {
                rb.AddForce(transform.right * speed);
            }
            else
            {
                rb.AddForce(transform.right * -speed);
            }

            timer = 0;
        }

        //if (rb.velocity.magnitude >= velocityLimit)
        //{
        //    rb.velocity = Vector3.zero;
        //}

        //if (!isGrounded)
        //{
        //    rb.AddForce(transform.right * 0);
        //}

        rb.AddForce(-transform.up * pull);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject)
    //    {
    //        isGrounded = true;
    //    }
    //}

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject)
    //    {
    //        isGrounded = false;
    //    }
    //}
}
