using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {
    public Transform musicPrefab;

    public static int currentScore = 0;
    public static int deathCounter = 0;

    public int test = 0;
    public float offsetX = 2; //Screen.width*0.5 - sizeX --> for center
    public float offsetY = 2;
    public float sizeX = 100;
    public float sizeY = 50;

    void OnGUI()
        {
        GUI.Box(new Rect(offsetX, offsetY, sizeX, sizeY), "Score: " + currentScore + "\nDeath: " + deathCounter);
        }

        // Use this for initialization
        void Start () {
        currentScore = 0;

        if (!GameObject.FindWithTag("MM"))
        {
            Transform mManager = Instantiate(musicPrefab, transform.position, Quaternion.identity);
            mManager.name = musicPrefab.name;
            DontDestroyOnLoad(mManager);
        }
	}
	
	// Update is called once per frame
	void Update () {
        test = currentScore;
	}
}
