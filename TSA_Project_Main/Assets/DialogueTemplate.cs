using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTemplate : MonoBehaviour {
	/*
	 Things to do before making dialogue:
	 1. Create a Canvas and click the checkbox to make it invisible
	 2.Under the Canvas (As a child object) add a 'Text' UI Element
	 3.Now if you look at the component of Text you newly added you will see a place where you can type the text.
	 4. Now add the Dialogue you want
	 5. Now as a component, attach this script to the Canvas
   If you have any questions email Sharad at sharadawsomeness@gmail.com (Yes it is spelled correctly0 or ask during the meetings
	 */
	public Canvas Dialogue;
	void Start () {
		if (Dialogue.enabled = true) {
			CloseCanvas ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		//Now depending on where the 
	}
	void OpenCanvas()
	{
		Dialogue.enabled = true;
		Time.timeScale = 0;
	}

	public void CloseCanvas()
	{
		Dialogue.enabled = false;
		Time.timeScale = 1;
	}
}
