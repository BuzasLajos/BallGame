using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHealth : MonoBehaviour {

    public float maxFloorDistance = -10.00F;
    public AudioClip gameOverSound;

    static bool isPlaying = false;
    // Use this for initialization
    void Start () {
        isPlaying = false;
    }

    // Update is called once per frame
    void Update () {
		if(transform.position.y <= maxFloorDistance && isPlaying==false)
        {
            isPlaying = true;
            GetComponent<AudioSource>().pitch = 1;
            GetComponent<AudioSource>().clip = gameOverSound;
            GetComponent<AudioSource>().PlayDelayed(0);

            StartCoroutine(RestartLevel("Level00"));

        }
    }//Update


    IEnumerator RestartLevel(string level)
    {
        Debug.Log("Game Over!");
        yield return new WaitForSeconds(2);
        UnityEngine.SceneManagement.SceneManager.LoadScene(level);
        GameMaster.deathCounter += 1;
    }//RestartLevel
}
