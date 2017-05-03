using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckState : MonoBehaviour {

	// Use this for initialization
	public GameObject Canvas;


	void Start ()
	{
		Debug.Log("Active Self: " + Canvas.activeSelf);
		Debug.Log("Active in Hierarchy" + Canvas.activeInHierarchy);
	}
}
/*
-----------------------------------------------------------------------------------------------------------------------------------------------
 * Project by: Sharad Khanna, Arjun Jagdeesh, Akash Jagdeesh, Joshua Terris, Ashwin Rajesh, and John Heo
 * For the Frost Video Game Design team ONLY
 * Script made by: Joshua
 * -----------------------------------------------------------------------------------------------------------------------------------------------
	*/
