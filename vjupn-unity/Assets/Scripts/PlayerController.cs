using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject bala;
    private Rigidbody2D rb;
    public float jumpForce = 50f;
    public float jumpVelocity = 1f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up*jumpForce);
        }
       /* else if (Input.GetKeyUp(KeyCode.I))
        {
            // Dispara hacia la izquierda
            var currentPosition = transform.position;
            var position = new Vector3(currentPosition.x - 1, currentPosition.y, 10);
            var balaGO = Instantiate(bala, position, Quaternion.identity);
            var controller = balaGO.GetComponent<BalaController>();
            controller.velocityX = -5f;
        }*/
        else if (Input.GetKeyUp(KeyCode.U))
        {
            // Dispara hacia la derecha
            var currentPosition = transform.position;
            var position = new Vector3(currentPosition.x + 1, currentPosition.y, 10);
            var balaGO = Instantiate(bala, position, Quaternion.identity);
            var controller = balaGO.GetComponent<BalaController>();
            controller.velocityX = 5f;
        }
    }
}