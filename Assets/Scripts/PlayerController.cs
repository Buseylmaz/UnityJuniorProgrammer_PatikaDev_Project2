using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    float horizontalInput;
    [SerializeField] private float playerSpeed;
    [SerializeField] private float xRange;
    

    public GameObject foodPrefab;
    
    
    void Update()
    {
        Move();
        BorderLimit();
        Food();
    }


    /// <summary>
    ///     Amac�m oyuncunun x eksenin de ki hareketi saglamak
    /// </summary>
    void Move()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * playerSpeed * horizontalInput);
    }


    /// <summary>
    //           Amac�m  x de belli konuma gelince(-20 ve 20 gibi) o konumda durmas� ve daha �tesine gidememesi yani kenar �izgisi belirliyoruz
    /// </summary>
    void BorderLimit()
    {

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }

    void Food()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
            
        }
    }
}
