using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvL3Movement : MonoBehaviour
{
    public float moveSpeed=10f;
    public SpriteRenderer sprite;
    public Animator animator;

    Rigidbody2D body;
    bool isGrounded;
    float horizontal;
    public float floatTime;
    public bool isCharacterOnPlanet;

    public GameObject hitBox;

    public bool attackAvailable = true;

    public float attackTime = 0;

    public Transform playerTransform;

    public Vector2 respawnCoordinates;

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

        if (attackTime > 1.5)
        {
            animator.SetBool("isAttacking", false);
        }

        if (attackTime > .1)
        {
            hitBox.SetActive(true);
        }

        if (attackTime > 1.5)
        {
            hitBox.SetActive(false);
        }
    }

    void FixedUpdate()
    {
        if (isGrounded)
        {
            body.AddForce(transform.right * horizontal * moveSpeed);
        }
        sprite.flipX = horizontal > 0 ? false : (horizontal < 0 ? true : sprite.flipX);

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



        if(floatTime > 2)
        {
            ResetPlayer();
        }

        if (!attackAvailable)
        {
            attackTime += Time.deltaTime;
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

    public void ResetPlayer()
    {
        body.velocity = new Vector2(0, 0);

        playerTransform.position = respawnCoordinates;
    }
}
