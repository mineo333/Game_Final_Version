using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wand_Buy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void BuyWand()
    {
        Score_Real.z -= 30;
    }
}
