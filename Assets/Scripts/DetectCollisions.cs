using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    /// <summary>
    /// Ama� �arp��malar� kontrol edip objeleri silmek
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);//steak i�in
        Destroy(other.gameObject);//dogs i�in
    }
}
