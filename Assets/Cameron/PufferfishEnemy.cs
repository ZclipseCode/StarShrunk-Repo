using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PufferfishEnemy : MonoBehaviour
{
    public float pufferTimer = 0f;

    public static bool isDashing = false;

    [SerializeField] int damage;

    private Rigidbody2D _rigidbody;

    public float turnSpeed = 200f;

    public float isBigEnemy = 0;

    public GameObject keyImage;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

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

    private void FixedUpdate()
    {
        _rigidbody.AddTorque(turnSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (!isDashing)
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
                if(isBigEnemy == 1)
                {
                    keyImage.SetActive(true);
                }

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
