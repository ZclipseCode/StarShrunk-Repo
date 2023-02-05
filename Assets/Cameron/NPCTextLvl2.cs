using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTextLvl2 : MonoBehaviour{
    public bool isPlayerByNPC = false,d1 = false;
    [SerializeField] private GameObject text1, text2;
    void OnTriggerStay2D(Collider2D obj){
        if (obj.CompareTag("Player")){
            isPlayerByNPC = true;
        }
    }
    private void OnTriggerExit2D(Collider2D obj) {
        isPlayerByNPC = false;
    }
    private void Update(){
        if (!isPlayerByNPC) {
            text1.SetActive(false);
            text2.SetActive(false);
        }
        else if (isPlayerByNPC && !d1) {
            text1.SetActive(true);
        }
        else
        {
            text2.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.E)){
                if (!d1 && isPlayerByNPC) {
                    text1.SetActive(false);
                    text2.SetActive(true);
                    d1 = true;
                }
                else {
                    text2.SetActive(false);
                    text1.SetActive(true);
                    d1 = false;
                }
        }
    }
}