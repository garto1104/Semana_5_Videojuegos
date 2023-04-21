using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaController : MonoBehaviour
{
    public float velocityX = 5f;
    public float velocityY = 5f;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.P))
        {
            GenerarBalas();
        }
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        Debug.Log("trigger");
        Debug.Log(other.gameObject.name);
        Destroy(this.gameObject);
    }

    public void GenerarBalas() 
    {
        // Generar dos balas adicionales
        var balaGO1 = Instantiate(gameObject, transform.position, Quaternion.identity);
        var balaController1 = balaGO1.GetComponent<BalaController>();
        balaController1.velocityX = velocityX - 1f;
        balaController1.velocityY = velocityY + 1f;

        var balaGO2 = Instantiate(gameObject, transform.position, Quaternion.identity);
        var balaController2 = balaGO2.GetComponent<BalaController>();
        balaController2.velocityX = velocityX + 1f;
        balaController2.velocityY = velocityY - 1f;
    }
}
