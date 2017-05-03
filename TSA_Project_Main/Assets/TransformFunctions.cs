using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformFunctions : MonoBehaviour {
	float moveSpeed = 3f;
	string change1 = "UpArrow";  //are we using the arrows or the WASD keys //There is another script for changing these variables based on the click of a button. This will allow the player to chose which one they want to use.
	string change2 = "DownArrow";
	string change3 = "LeftArrow";
	string change4 = "RightArrow";

	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
			transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);

		if (Input.GetKey(KeyCode.DownArrow))
			transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);//Change 2 is Down

		if (Input.GetKey(KeyCode.RightArrow))
			transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);//Change 3 is right

		if (Input.GetKey(KeyCode.LeftArrow))
			transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime); //Messed up. Change4 is A on the other script, this is going to the right.
	}
}
