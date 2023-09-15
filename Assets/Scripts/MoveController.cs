using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;


    void Update()
    {
        Move();

    }


    /// <summary>
    /// Ama�: Steak ve k�peklerin belirli h�zla ileriye dogru ilerlemsi
    /// </summary>
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
