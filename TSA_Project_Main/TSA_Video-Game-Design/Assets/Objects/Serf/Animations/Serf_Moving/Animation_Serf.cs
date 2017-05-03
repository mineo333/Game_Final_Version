 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Serf : MonoBehaviour {
    
	int AxeSet = 0;
	private Animator animator;
    float moveSpeed = 3f;
    float moveSpeed_2 = 2f;
    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");

		if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetInteger("Direction", 1);
            animator.SetFloat("Blend", 1.0f);
            transform.Translate(Vector2.up * moveSpeed_2 * Time.deltaTime);
            //			AxeSet = SetsAxe_Front (AxeSet);
            Debug.Log (AxeSet);
        }
		else if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetInteger("Direction", 3);
            animator.SetFloat("Blend", 1.0f);
            transform.Translate(-Vector2.up * moveSpeed_2 * Time.deltaTime);//Change 2 is Down
        }
		else if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("Direction", 2);
            animator.SetFloat("Blend", 1.0f);
            transform.Translate(Vector2.right * moveSpeed_2 * Time.deltaTime);
        }
		else if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("Direction", 0);
            animator.SetFloat("Blend", 1.0f);
            transform.Translate(-Vector2.right * moveSpeed_2 * Time.deltaTime);
        }
		//Begin WASD
		else if (Input.GetKey(KeyCode.W))
		{
			animator.SetInteger("Direction", 1);
			animator.SetFloat("Blend", 1.0f);
			transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.S))
		{
			animator.SetInteger("Direction", 3);
			animator.SetFloat("Blend", 1.0f);
			transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);//Change 2 is Down
		}
		else if (Input.GetKey(KeyCode.D))
		{
			animator.SetInteger("Direction", 2);
			animator.SetFloat("Blend", 1.0f);
			transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			animator.SetInteger("Direction", 0);
			animator.SetFloat("Blend", 1.0f);
			transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
		}
        else
        {
            animator.SetFloat("Blend", 0.0f);
        }
	//Axe Animation
		/*
		if (Input.GetKey (KeyCode.C)`Keycode C is the button to play the Axe Animation) {
			Debug.Log (AxeSet);
			animator.SetInteger ("Axe", AxeSet);
			animator.SetFloat ("Blend", 1f);

		}else{
			animator.SetFloat ("Blend", 0);
		 
	//Axe Animation END
		//Below Methods are nessecary
}
*/
/*	
		int SetsAxe_Right(int Axe){
			Axe = 1;
			return Axe;
		}
		int SetsAxe_Left(int Axe2){
			Axe2 = 2;

			return Axe2;
		}
		int SetsAxe_Back(int Axe3){
			Axe3 = 3;

			return Axe3;
		}
		int SetsAxe_Front(int Axe4){

			Axe4 = 4;
			return Axe4;
		}
		*/
}


}
