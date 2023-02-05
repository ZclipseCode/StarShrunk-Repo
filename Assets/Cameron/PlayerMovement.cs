using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed=10f, jumpPower=10f;
    public SpriteRenderer sprite;

    Rigidbody2D body;
    bool isGrounded;
    float horizontal;
    public float floatTime;
    public bool isCharacterOnPlanet;

    public Transform playerTransform;

    public Vector2 respawnCoordinates;

    Animator animator;
    public float attackTime = 0;
    public bool attackAvailable = true;
    public GameObject tounge;
    public SpriteRenderer toungeSprite;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            body.AddForce(transform.up * jumpPower, ForceMode2D.Impulse);
        }


        if (Input.GetKeyDown(KeyCode.Space) && attackAvailable)
        {
            animator.SetBool("isAttacking", true);
            attackAvailable = false;
            Debug.Log("player attacked");
            attackTime = 0;
        }

        if (attackTime > 2)
        {
            attackAvailable = true;
        }

        if(attackTime > 1.5)
        {
            animator.SetBool("isAttacking", false);
        }

        if(attackTime > .73333)
        {
            tounge.SetActive(true);
        }

        if(attackTime > 1.4)
        {
            tounge.SetActive(false);
        }
    }



    void FixedUpdate()
    {
        if (isGrounded)
        {
            body.AddForce(transform.right * horizontal * moveSpeed);
        }
        sprite.flipX = horizontal > 0 ? false : (horizontal < 0 ? true : sprite.flipX);

        toungeSprite.flipX = horizontal > 0 ? false : (horizontal < 0 ? true : toungeSprite.flipX);

        if (horizontal > 0)
        {
            tounge.transform.localPosition = new Vector2(6.31f, .15f);
        }
        else if (horizontal < 0)
        {
            tounge.transform.localPosition = new Vector2(-6.31f, .15f);
        }


        if (isCharacterOnPlanet)
        {
            floatTime = 0;
        }
        else if (!isCharacterOnPlanet)
        {
            floatTime += Time.deltaTime;
        }
        else
        {

        }



        if (!attackAvailable)
        {
            attackTime += Time.deltaTime;
        }


        if (floatTime > 2)
        {
            body.velocity = new Vector2 (0, 0);

            playerTransform.position = respawnCoordinates;
        }
    }

    void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.CompareTag("Planet"))
        {
            body.drag = 1f;

            isCharacterOnPlanet = true;

            float distance = Mathf.Abs(obj.GetComponent<GravityPoint>().planetRadius - Vector2.Distance(transform.position, obj.transform.position));
            if (distance < 1f)
            {
                isGrounded = distance < 0.5f;
            }
        }
    }

    void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Planet"))
        {
            body.drag = 0.2f;

            isCharacterOnPlanet = false;
        }
    }
}
