using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Score : MonoBehaviour {

    public static int score = 3;
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), ("Score = "+ score));

    }
}
/*
-----------------------------------------------------------------------------------------------------------------------------------------------
 * Project by: Sharad Khanna, Arjun Jagdeesh, Akash Jagdeesh, Joshua Terris, Ashwin Rajesh, and John Heo
 * For the Frost Video Game Design team ONLY
 * Script made by: Sharad
 * -----------------------------------------------------------------------------------------------------------------------------------------------
	*/
