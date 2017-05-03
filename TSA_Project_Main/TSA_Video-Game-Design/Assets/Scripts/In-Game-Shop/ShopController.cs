using UnityEngine;
using System.Collections;

public class ShopController : MonoBehaviour {

	public Canvas Canvas;

	void Start(){
		
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		Debug.Log ("Collision!");

		OpenShop ();

	}


	void OpenShop()
	{
		Canvas.enabled = true;
		//Time.timeScale = 0;


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
