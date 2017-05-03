using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_Follow : MonoBehaviour {

    float moveSpeed = 3f;
    float moveSpeed_2 = 3f;
    public GameObject Player;
    // Use this for initialization
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
               


        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.Translate(Vector2.up * moveSpeed_2 * Time.deltaTime);
            //			AxeSet = SetsAxe_Front (AxeSet);
            
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector2.up * moveSpeed_2 * Time.deltaTime);//Change 2 is Down
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
           
            transform.Translate(Vector2.right * moveSpeed_2 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
           
            transform.Translate(-Vector2.right * moveSpeed_2 * Time.deltaTime);
        }
        //Begin WASD
        else if (Input.GetKey(KeyCode.W))
        {
            
            transform.Translate(Vector2.up * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
           
            transform.Translate(-Vector2.up * moveSpeed * Time.deltaTime);//Change 2 is Down
        }
        else if (Input.GetKey(KeyCode.D))
        {
            
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            
            transform.Translate(-Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            
        }
        
}

    }


