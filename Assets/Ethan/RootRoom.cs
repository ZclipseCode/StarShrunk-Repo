using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootRoom : MonoBehaviour{
    public GameObject player, openState, closedState, keyUIObj;
    public bool hasKey = false, isClosed = true, isPlayerNearRoom;
    void Update(){
        if(isPlayerNearRoom && Input.GetKeyDown(KeyCode.E)) {
            if (isClosed && hasKey){
                openState.SetActive(true);
                closedState.SetActive(false);
            }
            else if (!isClosed) {
                //change to next scene
            }
        }
    }
    void OnTriggerStay2D(Collider2D obj){
        if (obj.CompareTag("Player")) {
            isPlayerNearRoom = true;
        }
    }
}
