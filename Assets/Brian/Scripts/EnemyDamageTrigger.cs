using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageTrigger : MonoBehaviour
{
    [SerializeField] int damage;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            PlayerHealth ph = collision.gameObject.GetComponent<PlayerHealth>();
            ph.TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}
