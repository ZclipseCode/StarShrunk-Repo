using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetFromBetween : MonoBehaviour
{
    bool isSurfaced = true;
    [SerializeField] float floatingTime;
    float timer;
    [SerializeField] LvL3Movement movementScript;

    void Start()
    {

    }

    void Update()
    {
        if (!isSurfaced)
        {
            timer += Time.deltaTime;

            if (timer >= floatingTime)
            {
                movementScript.ResetPlayer();
                timer = 0;
            }
        }
        else
        {
            timer = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Surface")
        {
            isSurfaced = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Surface")
        {
            isSurfaced = false;
        }
    }
}
