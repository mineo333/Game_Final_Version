using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen_Move : MonoBehaviour {
	private Animator animator;
	public float moveSpeed = 4f;
	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		var vertical = Input.GetAxis("Vertical");
		var horizontal = Input.GetAxis("Horizontal");
        animator.SetInteger("Direction", 2);
        
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
