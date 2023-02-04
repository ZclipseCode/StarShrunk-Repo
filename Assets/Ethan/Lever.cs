using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Item you want to dissapear
    public GameObject blockade;
    public bool isPlayerByLever;


    void OnTriggerStay2D(Collider2D obj){
        // Checks if player is standing inside the lever box collider
        if (obj.CompareTag("Player")){
            // If the player presses E while standing inside the box collider
            // it deactivates whatever GameObjects are set to blockade

            isPlayerByLever = true;

            if (Input.GetKey(KeyCode.E)){
                blockade.SetActive(false);
            }
        }
    } 
}