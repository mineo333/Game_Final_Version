using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Real : MonoBehaviour {

	// Use this for initialization
	//public static class GlobalVariables{
	public Button yourButton;
		public static int Score = 0;
		public static int z = 0;
	public Canvas Canvas;
		//}
	public Text timerLabel;
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		Debug.Log (z);
		string Score_real = "Wood = " + z.ToString ();
		timerLabel.text = Score_real;
		if ( z == 5){
			
	}
}
}