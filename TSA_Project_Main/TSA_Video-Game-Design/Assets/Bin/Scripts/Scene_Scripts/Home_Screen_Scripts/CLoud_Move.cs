﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CLoud_Move : MonoBehaviour {
	float moveSpeed = 0.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);	
	}
}
