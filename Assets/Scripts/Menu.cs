using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

	public void StartGame()
    {
        Application.LoadLevel(1);
        Time.timeScale = 1;
    }
    public void Exit()
    {
        Application.Quit();
    }

    public void ToMenu()
    {
        Application.LoadLevel(0);
        Time.timeScale = 1;
    }
}
