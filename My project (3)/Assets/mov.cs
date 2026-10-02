using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public float moveSpeed;
    public KeyCode L;//L is the name we gave a keyboard button we chose to be the left movement button.
    public KeyCode R;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*   if(Input.GetKeyDown(Spacebar) && grounded) //When user presses the space button ONCE
        {
            Jump(); //see function definition below   
        }
       */
        if (Input.GetKey(L)) //When user presses the left arrow button
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y); 
            //player character moves horizontally to the left along the x-axis without disrupting jump

            if(GetComponent<SpriteRenderer>()!=null)
            {
                GetComponent<SpriteRenderer>().flipX = true;
            }           
        }
      
        if (Input.GetKey(R)) //When user presses the left arrow button
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y); 
            //player character moves horizontally to the right along the x-axis without disrupting jump

            if(GetComponent<SpriteRenderer>()!=null)
            {
                GetComponent<SpriteRenderer>().flipX = false;
            }   
        }
        
    }
}
