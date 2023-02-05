using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentOnDestroy : MonoBehaviour
{
    private void OnDestroy() {
        GameManager.tentKilled++;
    }
}
