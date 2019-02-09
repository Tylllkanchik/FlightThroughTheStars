using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, Input.GetAxis("Vertical") * 12f);
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, -4.4f, 4.4f));
    }
}
