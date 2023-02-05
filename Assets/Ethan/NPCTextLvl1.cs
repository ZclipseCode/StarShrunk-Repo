using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCTextLvl1 : MonoBehaviour{
    public bool isPlayerByNPC = false,d1 = false,d2 = false, d3 = false;
    [SerializeField] private GameObject questItem ,text1, text2, text3, text4;
    [SerializeField] private GameObject completeText1, completeText2, keyUI;
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
            text3.SetActive(false);
            text4.SetActive(false);
            completeText1.SetActive(false);
            completeText2.SetActive(false);
            d1 = false; d2 = false; d3 = false;
        }
        else if (isPlayerByNPC && !d1) {
            text1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.E)){
            if (!questItem.activeInHierarchy) {
                if (!d1 && isPlayerByNPC) {
                    text1.SetActive(false);
                    completeText1.SetActive(true);
                    d1 = true;
                }
                else if (!d2 && isPlayerByNPC) {
                    completeText1.SetActive(false);
                    completeText2.SetActive(true);
                    keyUI.SetActive(true);
                    d2 = true;
                }
                else {
                    completeText2.SetActive(false);
                    text1.SetActive(true);
                    d2 = false; d1 = false;
                }
            }
            else {
                if (!d1 && isPlayerByNPC) {
                    text1.SetActive(false);
                    text2.SetActive(true);
                    d1 = true;
                }
                else if (!d2 && isPlayerByNPC) {
                    text2.SetActive(false);
                    text3.SetActive(true);
                    d2 = true;
                }
                else if (!d3 && isPlayerByNPC) {
                    text3.SetActive(false);
                    text4.SetActive(true);
                    d3 = true;
                }
                else {
                    text4.SetActive(false);
                    text1.SetActive(true);
                    d1 = false; d2 = false; d3 = false;
                }
            }
        }
    }
}