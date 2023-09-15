using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    float topBound = 30.0f;
    float lowerBound = -10;


    /// <summary>
    /// Ama�:S�n�r d���na ��kan mermileri ve  hayvanlar� yok etme 
    /// </summary>
    void Update()
    {
        //   !!!!!! �lk defa bu yap�y� g�rd�m

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
