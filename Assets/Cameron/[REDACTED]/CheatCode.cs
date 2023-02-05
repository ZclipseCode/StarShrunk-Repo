using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatCode : MonoBehaviour
{
    private bool typedB = false;
    private bool typedR = false;
    private bool typedI = false;
    private bool typedA = false;
    private bool typedN = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (!typedB)
            {
                typedB = true;
            }
            else if (typedB)
            {
                typedB = false;
                typedR = false;
                typedI = false;
                typedA = false;
                typedN = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.R))
        {
            if (!typedR)
            {
                typedR = true;
            }
            else if (typedR)
            {
                typedB = false;
                typedR = false;
                typedI = false;
                typedA = false;
                typedN = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            if (!typedI)
            {
                typedI = true;
            }
            else if (typedI)
            {
                typedB = false;
                typedR = false;
                typedI = false;
                typedA = false;
                typedN = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            if (!typedA)
            {
                typedA = true;
            }
            else if (typedA)
            {
                typedB = false;
                typedR = false;
                typedI = false;
                typedA = false;
                typedN = false;
            }
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            if (!typedN)
            {
                typedN = true;
            }
            else if (typedN)
            {
                typedB = false;
                typedR = false;
                typedI = false;
                typedA = false;
                typedN = false;
            }
        }

        if (typedN)
        {
            SceneManager.LoadScene("Secret Scene");
            typedB = false;
            typedR = false;
            typedI = false;
            typedA = false;
            typedN = false;
        }
    }
}
