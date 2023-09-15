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
    /// Amaç: Steak ve köpeklerin belirli hýzla ileriye dogru ilerlemsi
    /// </summary>
    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
