using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue_Start_King : MonoBehaviour {
	public Canvas Canvas;
	public GameObject Player;
	public GameObject Player2;
	// Use this for initialization

	
	// Update is called once per frame

	void OnCollisionEnter2D(Collision2D other){
		Canvas.enabled = true;
		Destroy (Player);
		Player2.GetComponent<Animator>().enabled = true;
		Player2.GetComponent<SpriteRenderer>().enabled = true;

	}
}
