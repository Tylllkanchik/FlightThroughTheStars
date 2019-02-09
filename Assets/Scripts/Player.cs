using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour {

    private int score = 0;
    public GameObject gameOverPref;
    public Text points;

    private Playerlife playerlife = Playerlife.alive;

    private void Update()
    {
        if (playerlife != Playerlife.dead)
        {
            points.text = scoreAdd();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        // Application.LoadLevel(0);
        gameOverPref.SetActive(true);
        playerlife = Playerlife.dead;
        gameOverPref.transform.Find("TotalPoints").GetComponent<Text>().text = score.ToString();
        Time.timeScale = 0;
    }
    private string scoreAdd()
    {
        score++;
        return score.ToString();
    }

    enum Playerlife
    {
        alive,
        dead
    }

}
