using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl3Attack : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Debug.Log("Die");
        }
        Debug.Log(collision.gameObject.tag);
    }
}
