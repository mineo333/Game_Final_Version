using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serf_Movement : MonoBehaviour {
    float timef = 3;
    float moveSpeed = 3f;
    float Timer = 0;
    float coolDown = 3;
    private Animator animator;
    private float timeStamp;
    private GameObject left;
    private GameObject right;
    // Use this for initialization
    void Start () {
        animator = this.GetComponent<Animator>();
        left = GameObject.FindGameObjectWithTag("Left");
        right = GameObject.FindGameObjectWithTag("Right");
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        animator.SetInteger("Direction", 3);
        animator.SetFloat("Blend", 1.0f);
        /* transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
         animator.SetInteger("Direction", 2);
         animator.SetFloat("Blend", 1.0f);

         Timer += Time.deltaTime;
          if( Timer > timef)
         {
             Timer = 0;
             transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
             animator.SetInteger("Direction", 3);
             animator.SetFloat("Blend", 1.0f);
             */
        /*
   timeStamp = Time.time + coolDown;

   if (timeStamp <= Time.time)
   {
       transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
       animator.SetInteger("Direction", 3);
       animator.SetFloat("Blend", 1.0f);
       timeStamp = 0;
   }
   else
   {
       transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
       animator.SetInteger("Direction", 2);
       animator.SetFloat("Blend", 1.0f);
       */

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Left")
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
            animator.SetInteger("Direction", 3);
            animator.SetFloat("Blend", 1.0f);
        }else
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
            animator.SetInteger("Direction", 2);
            animator.SetFloat("Blend", 1.0f);
        }
      
    }
}
    

