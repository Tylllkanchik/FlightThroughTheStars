using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMovement : MonoBehaviour {

    public float speed;
    public float Rotatespeed;

    private Rigidbody2D rb;
    public CircleCollider2D circleCollider;



    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        circleCollider = gameObject.AddComponent<CircleCollider2D>();

    }

    private void Start()
    {
        rb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);

    }

    void FixedUpdate()
    {
        OrbitAround(Rotatespeed);
    }
    public void OrbitAround(float Rotatespeed)
    {
        rb.AddTorque(Rotatespeed);
    }
}
