using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI1 : MonoBehaviour {

	private Transform target; //the enemy's target
	float speed = 10f; //move speed
	float rotationSpeed = 6f; //speed of turning
	private string spriteNames = "serf-left-move-1";
	private SpriteRenderer spriteRenderer;

	private Transform targetTransform; //current transform data of this enemy





	void Start()
	{
		targetTransform = GameObject.FindWithTag("Player").transform; //target the player
		spriteRenderer = GetComponent<SpriteRenderer>();
		Resources.LoadAll<Sprite>(spriteNames);

	}

	void Update(){
		
			
				//rotate to look at the player
		Vector3 vectorToTarget = targetTransform.position - transform.position;
		float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
		Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeed);
		//transform.position += targetTransform * speed * Time.deltaTime; 

		//move to player
		targetTransform.position += targetTransform.forward * Time.deltaTime * speed;

	
		//Quaternion.LookRotation(target.position - targetTransform.position), rotationSpeed * Time.deltaTime);
		//transform.Translate (target.position - targetTransform.position);

				//play cast animation
				//Script and variable name need to be changed based on what is in the final script
				//Instantiate(magic);


		float rotation = transform.eulerAngles.z;
		if (rotation > 0)
		{
			changesprite();
		}
		if (rotation >= 90)
		{
			//Change to sprite 2
		}
		if (rotation >= 90)
		{
			//Change to sprite 3
		}
		if (rotation >= 90)
		{
			//Change to sprite 4
		}
	}
	void changesprite()
	{
		//spriteRenderer.sprite = apple;
	}
			
		}
	
		
	

