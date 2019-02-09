using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateAsteroid : MonoBehaviour {

    private AsteroidMovement asteroidMovement;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        asteroidMovement = GetComponent<AsteroidMovement>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    public void createAsteroid(Asteroid asteroid,float k)
    {
        asteroidMovement.speed = asteroid.speed + k;
        asteroidMovement.Rotatespeed = asteroid.rotationM;
        spriteRenderer.sprite = asteroid.sprite;
        asteroidMovement.circleCollider.radius = asteroid.radiusM;
    }
}
