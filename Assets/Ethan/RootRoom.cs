using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RootRoom : MonoBehaviour{
    public GameObject player, openState, closedState, keyUIObj;
    public bool hasKey = false, isClosed = true, isPlayerNearRoom;
    void Update(){
        hasKey = keyUIObj.activeInHierarchy;
        if(isPlayerNearRoom && Input.GetKeyDown(KeyCode.E)) {
            if (isClosed && hasKey){
                openState.SetActive(true);
                closedState.SetActive(false);
                isClosed = false;
            }
            else if (!isClosed) {
                SceneManager.LoadScene("Cam LVL2");
            }
        }
    }
    void OnTriggerStay2D(Collider2D obj){
        if (obj.CompareTag("Player")) {
            isPlayerNearRoom = true;
        }
    }
    private void OnTriggerExit2D(Collider2D obj) {
        isPlayerNearRoom = false;
    }
}
