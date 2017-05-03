using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MonoBehaviour {
	public Canvas Canvas;
    public GameObject CPlayer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown(){
        CPlayer.GetComponent<TransformFunctions>().enabled = true;
    }

	public void CloseShop()
	{
		Canvas.enabled = false;
		//Time.timeScale = 1;
	}
}
/*
-----------------------------------------------------------------------------------------------------------------------------------------------
 * Project by: Sharad Khanna, Arjun Jagdeesh, Akash Jagdeesh, Joshua Terris, Ashwin Rajesh, and John Heo
 * For the Frost Video Game Design team ONLY
 * Script made by: Sharad
 * -----------------------------------------------------------------------------------------------------------------------------------------------
	*/
