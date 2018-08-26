using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public AudioSource music;
    public void QuitGame() {
        Debug.Log("Game is exiting...");
        Application.Quit();
    }

    public void StartGame(string level)
    {
        Application.LoadLevel(level);
    }

    public void SetGameVolume(float vol)
    {
        music.volume = vol;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
