using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    public float speed =5f;                

    private Rigidbody2D rb;

    Vector2 movement;

    public Vector3 respawnPoint;

    void Start()
    {  
        rb= GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
       // movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
