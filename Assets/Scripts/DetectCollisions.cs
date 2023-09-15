using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    /// <summary>
    /// Amaç çarpýþmalarý kontrol edip objeleri silmek
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//steak için
        Destroy(other.gameObject);//dogs için
    }
}
