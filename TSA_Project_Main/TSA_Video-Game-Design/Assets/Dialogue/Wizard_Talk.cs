using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard_Talk : MonoBehaviour {
	public Canvas Canvas;
	public Canvas Objective1;
	public Canvas Objective2;
	public GameObject ShopKeeper;

	// Use this for initialization

	void Start () {
		
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			Canvas.enabled = true;
			Objective1.enabled = false;
			Objective2.enabled = true;
            ShopKeeper.GetComponent<ShopController>().enabled = true;
            ShopKeeper.GetComponent<BoxCollider2D>().enabled = true;
            ShopKeeper.GetComponent<SpriteRenderer>().enabled = true;

        }
	}
	
	// Update is called once per frame
	void Update () {
		{
			
			Debug.Log ("Collision!");



		}
	}
}
