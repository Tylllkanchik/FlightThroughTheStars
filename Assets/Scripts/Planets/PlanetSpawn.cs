using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpawn : MonoBehaviour {

    public GameObject planetPref;

    public Sprite[] sprite;

    private SpriteRenderer spriteRenderer;

    public float time;

    //private int currentPlanet = 0;

    private void Awake()
    {
        StartCoroutine(begin());
    }


    IEnumerator begin()
    {
        for (int i = 0; i < sprite.Length; i++)
        {
            yield return new WaitForSeconds(time);
            GameObject planet = Instantiate(planetPref);
            spriteRenderer = planet.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = sprite[i];
        }
    }


}
