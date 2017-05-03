using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_FIght : MonoBehaviour {
	private Animator animator;

	void OnCollisionEnter2D(Collision2D other){
		
	}
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.F)) {
			animator.SetInteger ("Wand", 1);
			animator.SetFloat ("Blend", 1.0f);
		} else {
			
			animator.SetFloat("Blend", 0.0f);
		}
	}
}