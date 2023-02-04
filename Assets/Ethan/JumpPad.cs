using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour{
    public Rigidbody2D player;
    public float jumpPadPower = 10f;
    private void OnTriggerEnter2D(Collider2D obj){
        if(obj.CompareTag("Player")){
            player.AddForce(transform.up * jumpPadPower, ForceMode2D.Impulse);
        }
    }
}
