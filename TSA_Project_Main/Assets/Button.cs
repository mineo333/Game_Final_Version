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
