using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterMovement : MonoBehaviour
{
    public float thrustSpeed = 1f;
    public float turnSpeed = 1f;
    public float dashSpeed = 5f;
    public float dashCooldown;
    public bool dashAvailable = true;

    public bool inCircle = true;

    private Rigidbody2D _rigidbody;
    private bool _thrusting;
    private float _turnDirection;

    // Start is called before the first frame update
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        _thrusting = Input.GetKey(KeyCode.W);

        if (Input.GetKey(KeyCode.A))
        {
            _turnDirection = 1f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _turnDirection = -1f;
        }
        else
        {
            _turnDirection = 0f;
        }   
    }

    private void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.CompareTag("Swimable"))
        {
            inCircle = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.CompareTag("Swimable"))
        {
            inCircle = true;
        }
    }

    private void OnTriggerStay2D(Collider2D obj)
    {
        if (obj.CompareTag("Swimable"))
        {
            inCircle = true;
        }
    }

    private void FixedUpdate()
    {
        if (_thrusting)
        {
            _rigidbody.AddForce(this.transform.right * this.thrustSpeed);
        }

        if (!inCircle)
        {
            _rigidbody.AddForce(this.transform.right * -this.thrustSpeed * 8);
        }

        if (_turnDirection != 0f)
        {
            _rigidbody.AddTorque(_turnDirection * this.turnSpeed);
        }

        if (Input.GetKey(KeyCode.Space) && dashAvailable)
        {
            //Debug.Log("pressed space");
            _rigidbody.AddForce(this.transform.right * dashSpeed);
            dashCooldown = 0;
            dashAvailable = false;
        }

        if (!dashAvailable)
        {
            dashCooldown += Time.deltaTime;
        }

        if (dashCooldown > 1)
        {
            dashAvailable = true;
        }
    }
}
