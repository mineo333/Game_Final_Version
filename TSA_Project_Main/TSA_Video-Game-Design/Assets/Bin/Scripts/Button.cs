using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	// Use this for initializatio
	void OnMouseDown(){
		Debug.Log ("Click");
		Destroy (this.gameObject);
	}
}
/*
-----------------------------------------------------------------------------------------------------------------------------------------------
 * Project by: Sharad Khanna, Arjun Jagdeesh, Akash Jagdeesh, Joshua Terris, Ashwin Rajesh, and John Heo
 * For the Frost Video Game Design team ONLY
 * Script made by: Sharad
 * -----------------------------------------------------------------------------------------------------------------------------------------------
	*/
