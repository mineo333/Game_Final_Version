using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene_Change_City : MonoBehaviour {


    public Canvas Canvas;
		// Use this for initialization
		void Start () {

		}
		void OnCollisionEnter2D(Collision2D other){
			if (other.gameObject.tag == "Player") {
            Canvas.enabled = true;
			}
		}
		// Update is called once per frame
		void Update () {

		}
	}


