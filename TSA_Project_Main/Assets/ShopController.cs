using UnityEngine;
using System.Collections;

public class ShopController : MonoBehaviour {

	public Canvas Canvas;
	public GameObject Player;
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
		Player.GetComponent<TransformFunctions>().enabled = false; 

	}

	public void CloseShop()
	{
		Canvas.enabled = false;
		//Time.timeScale = 1;
	}
}