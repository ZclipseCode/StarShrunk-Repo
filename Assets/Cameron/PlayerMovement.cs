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

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            body.AddForce(transform.up * jumpPower, ForceMode2D.Impulse);
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
