﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Scene_1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseDown()
    {
        Application.LoadLevel(1);
    }

    }
