using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDestroy : MonoBehaviour {
	public GameObject Score;
	int i = 0;
	public int GetScore = Score_Real.z;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			
	}
	private void OnMouseDown()
    {
        //this.enabled = false;


        this.GetComponent<SpriteRenderer>().enabled = false;
		this.GetComponent<CapsuleCollider2D>().enabled = false;

		++Score_Real.z;

		//Score.GetComponent<Score_Real>().Score = i;
		GetScore++;
		Score_Real.Score = GetScore;




    }

}
/*
-----------------------------------------------------------------------------------------------------------------------------------------------
 * Project by: Sharad Khanna, Arjun Jagdeesh, Akash Jagdeesh, Joshua Terris, Ashwin Rajesh, and John Heo
 * For the Frost Video Game Design team ONLY
 * Script made by: Sharad
 * -----------------------------------------------------------------------------------------------------------------------------------------------
	*/
