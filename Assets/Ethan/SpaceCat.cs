using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceCat : MonoBehaviour{
    [SerializeField] private bool isPlayerByCat = false;
    [SerializeField] private GameObject cat;
    void Update(){
        if (Input.GetKeyDown(KeyCode.E)) {
            if (isPlayerByCat) {
                cat.SetActive(false);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D obj) {
        if (obj.CompareTag("Player")) {
            isPlayerByCat = true;
        }
    }
}
