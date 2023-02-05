using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PufferfishEnemy : MonoBehaviour
{
    public float pufferTimer = 0f;

    public static bool isDashing = false;

    [SerializeField] int damage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pufferTimer += Time.deltaTime;

        if (pufferTimer >= 3)
        {
            pufferTimer = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            if (pufferTimer < 2.1667)
            {

            }
            else if(pufferTimer > 2.1667 && pufferTimer < 3)
            {
                PlayerHealth ph = collision.gameObject.GetComponent<PlayerHealth>();
                ph.TakeDamage(damage);
            }

            
        }


        if (isDashing)
        {
            if (pufferTimer < 2.1667)
            {
                
                Destroy(gameObject);
            }
            else if (pufferTimer > 2.1667 && pufferTimer < 3)
            {
                PlayerHealth ph = collision.gameObject.GetComponent<PlayerHealth>();
                ph.TakeDamage(damage);
            }


        }
    }
}
