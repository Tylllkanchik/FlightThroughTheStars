using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public float waiting;

    public Asteroid[] asteroids;
    public GameObject asteroidPref;

    [SerializeField]
    private float[] chances;

    [SerializeField]
    private float k = 0;

    void Start () {

        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(waiting);

            Vector2 spawnPos = new Vector2(12, Random.Range(-4f, 4f));
            GameObject ob = Instantiate(asteroidPref, spawnPos, Quaternion.identity);
            CreateAsteroid asteroid =  ob.GetComponent<CreateAsteroid>();
            asteroid.createAsteroid(asteroids[ChooseRandomWithChance(chances)],k);
            returnK();
            returnWaiting();
            Destroy(ob, 7f);

        }
    }

    private float returnWaiting()
    {
        if(waiting < 1f)
        {
            if (waiting < 0.25f)
            {
                return waiting;
            }
            return waiting -=  0.015f;
        }

        return waiting -=  0.05f;
    }

    private float returnK()
    {
        if(k < 5)
        {
            return k += 0.05f;
        }
        return k;
    }

    private int ChooseRandomWithChance(float[] probs)
    {

        float total = 0;

        foreach (float elem in probs)
        {
            total += elem;
        }

        float randomPoint = Random.value * total;

        for (int i = 0; i < probs.Length; i++)
        {
            if (randomPoint < probs[i])
            {
                return i;
            }
            else
            {
                randomPoint -= probs[i];
            }
        }
        return probs.Length - 1;
    }
}
