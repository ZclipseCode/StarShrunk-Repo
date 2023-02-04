using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFOBeam : MonoBehaviour
{
    [SerializeField] float lifespan;
    float timer;
    [SerializeField] float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = -transform.up * speed;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= lifespan)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Surface")
        {
            Destroy(gameObject);
        }
    }
}
