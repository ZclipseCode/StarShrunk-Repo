using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DT : MonoBehaviour
{

    public Dialogue dialogue;

    public void TD()
    {

        FindObjectOfType<DM>().SD(dialogue);
    
    }
}
