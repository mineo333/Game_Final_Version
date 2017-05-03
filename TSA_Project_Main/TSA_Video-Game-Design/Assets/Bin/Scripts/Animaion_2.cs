using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaion_2 : MonoBehaviour {
    private Animator animator;

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
        }
        else
        {
            animator.SetFloat("Blend", 0.0f);
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            animator.SetInteger("Direction", 3);
            animator.SetFloat("Blend", 1.0f);
            
        }
        else
        {
            animator.SetFloat("Blend", 0.0f);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("Direction", 2);
            animator.SetFloat("Blend", 1.0f);
        }else
        {
            animator.SetFloat("Blend", 0.0f);
        }


        if (Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("Direction", 0);
            animator.SetFloat("Blend", 1.0f);

        }
        else
        {
            animator.SetFloat("Blend", 0.0f);
        }
    }
}
