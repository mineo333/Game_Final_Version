using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge_Builder : MonoBehaviour {
	public Canvas Canvas;

	public void onClick(){
		Canvas.enabled = false;
		Score_Real.z -= 1;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
