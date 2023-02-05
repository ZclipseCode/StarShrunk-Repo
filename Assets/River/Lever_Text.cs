using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever_Text : MonoBehaviour
{
    // text cycle
    public bool isPlayerByNPC,d1 = false,d2 = false, d3 = false;
    public bool start = true;
    public Dialogue dialogue;
    [SerializeField] private string str;
    [SerializeField] private GameObject floatingTextPrefab;
    [SerializeField] private GameObject text1, text2, text3;

    void ShowText(string text) 
    {
        if (floatingTextPrefab) 
        {
            GameObject prefab = Instantiate(floatingTextPrefab, transform.position, Quaternion.identity);
            prefab.GetComponentInChildren<TextMesh>().text = text;
        }
    }
    void OnTriggerStay2D(Collider2D obj)
    {
        // Checks if player is standing inside the lever box collider
        if (obj.CompareTag("Player"))
        {
            // If the player presses E while standing inside the box collider
            // it deactivates whatever GameObjects are set to blockade

            isPlayerByNPC = true;
        }
    }
    private void Update()
    {
        
        if (start == true)
        {
            Debug.Log("Talk to me");
            start = false; 
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            if (isPlayerByNPC && !d1)
            {
                Debug.Log("Hello");
                text1.SetActive(false);
                text2.SetActive(true);
                d1 = true;
            }
            else if (isPlayerByNPC && !d2)
            {
                Debug.Log("erm");
                text2.SetActive(false);
                text3.SetActive(true);
                d2 = true;
            }
            else if (isPlayerByNPC && !d3)
            {
                Debug.Log("uggg");
                text3.SetActive(false);
                d3 = true;
            }
            else if (d1 && d2 && d3 == true) 
            {
                d1 = false;
                d2 = false;
                d3 = false;
            }
        }
    }
}