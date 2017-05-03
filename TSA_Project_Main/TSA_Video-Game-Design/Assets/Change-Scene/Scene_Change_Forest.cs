using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Change_Forest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player" && Score_Real.z   >= 100) {
			Application.LoadLevel (3);
		}
		}
	// Update is called once per frame
	void Update () {
		
	}
}
