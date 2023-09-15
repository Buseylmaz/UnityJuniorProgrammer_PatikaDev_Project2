using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float topBound = 30.0f;
    float lowerBound = -10;


    /// <summary>
    /// Amaç:Sýnýr dýþýna çýkan mermileri ve  hayvanlarý yok etme 
    /// </summary>
    void Update()
    {
        //   !!!!!! Ýlk defa bu yapýyý gördüm

        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Oyun Biiti");
            Destroy(gameObject);
        }
    }
}
