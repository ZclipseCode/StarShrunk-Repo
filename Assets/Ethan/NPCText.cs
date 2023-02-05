using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCText : MonoBehaviour{
    public bool isPlayerByNPC,d1 = false,d2 = false, d3 = false;
    [SerializeField] private GameObject text1, text2, text3, text4;
    void OnTriggerStay2D(Collider2D obj){
        if (obj.CompareTag("Player")){
            isPlayerByNPC = true;
        }
    }
    private void Update(){
        if (Input.GetKeyDown(KeyCode.E)){
            if (isPlayerByNPC && !d1){
                text1.SetActive(false);
                text2.SetActive(true);
                d1 = true;
            }
            else if (isPlayerByNPC && !d2){
                text2.SetActive(false);
                text3.SetActive(true);
                d2 = true;
            }
            else if (isPlayerByNPC && !d3){
                text3.SetActive(false);
                text4.SetActive(true);
                d3 = true;
            }
            else if (d1 && d2 && d3){
                text4.SetActive(false);
                text1.SetActive(true);
                d1 = false;
                d2 = false;
                d3 = false;
            }
        }
    }
}