using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour {


    public float speed;

    [SerializeField]
    private Transform startPoint;

    private PlanetSpawn planetSpawn;


    private void Awake()
    {
        planetSpawn = FindObjectOfType<PlanetSpawn>();
    }

    private void Start()
    {
        startPointPosition();
        StartCoroutine(returnPlanet());
    }

    void Update () {

        if(transform.position.x > -14)
        {
            transform.Translate(new Vector2(-1, 0) * speed * Time.deltaTime);
        }
	}

    private void startPointPosition()
    {
        transform.position = startPoint.position;
    }
    IEnumerator returnPlanet()
    {
        while (true)
        {
            yield return new WaitForSeconds(planetSpawn.time*planetSpawn.sprite.Length);
            startPointPosition();
        }

    }
}
