using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleVary : MonoBehaviour
{
    public bool playing = false;
    private void Update()
    {
        if(!playing)
        {
            playing = true;
            StartCoroutine(Scaler());
        }
    }

    IEnumerator Scaler()
    {
        transform.localScale = new Vector3(1, 1, 0);
        yield return new WaitForSeconds(1f);
        transform.localScale = new Vector3(.33f, 0.33f, 0);
        yield return new WaitForSeconds(1f);
        transform.localScale = new Vector3(1, 1, 0);
        playing = false;
    }
}
