using UnityEngine;
using System.Collections;

public class ShopController1 : MonoBehaviour {

	public GameObject shopPanel;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Player"))
			OpenShop ();
		Debug.Log ("COllsion!");
	}

	void OpenShop()
	{
		shopPanel.SetActive (true);
		Time.timeScale = 0;
	}

	public void CloseShop()
	{
		shopPanel.SetActive (false);
		Time.timeScale = 1;
	}
}