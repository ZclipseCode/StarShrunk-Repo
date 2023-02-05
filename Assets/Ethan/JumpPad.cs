using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour{
    public Rigidbody2D player;
    public float jumpPadPower = 10f;

    bool input;

    private void Update()
    {
        if (Input.GetKey(KeyCode.E)){
            input = true;
        }
        else
        {
            input = false;
        }
    }

    private void OnTriggerStay2D(Collider2D obj){
        if(obj.tag == "Player" && input){
            player.AddForce(transform.up * jumpPadPower, ForceMode2D.Impulse);
        }
    }
}
