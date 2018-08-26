using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    public Transform coinEffect;

    void OnTriggerEnter(Collider info) {
        if (info.tag == "Player") {
            // Debug.Log("Coin collected"); 
            //TODO>: Coin counter
            GameMaster.currentScore += 1;
            Transform effect = Instantiate(coinEffect, transform.position, transform.rotation);
            Destroy(effect.gameObject, 3);
            Destroy(gameObject);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
