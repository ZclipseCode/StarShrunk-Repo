using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LumpOnDestroy : MonoBehaviour
{
    private void OnDestroy() {
        GameManager.lumpEaten++;
    }
}
