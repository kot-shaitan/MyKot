using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.Jobs.LowLevel.Unsafe;
using UnityEngine;

public class Run : MonoBehaviour
{   
    public float WalkingSpeed = 50f;
    public float JumpForce = 10f;
    private Rigidbody2D capybara;
    public Animator animator;

    SpriteRenderer capy;
    

    void Start()
    {
        capybara = gameObject.GetComponent<Rigidbody2D>();
        capy = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
        if (Input.GetKey(KeyCode.D)) 
        {

            capybara.velocity = Vector2.right * WalkingSpeed;
            animator.SetFloat("speed", 5);
            capy.flipX = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            animator.SetFloat("speed", 5);
            capybara.velocity = Vector2.left * WalkingSpeed;
            capy.flipX = false;
        }
        else {
            animator.SetFloat("speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space)) { 

                
            //capybara.AddForce(Vector2.up * JumpForce);
            capybara.velocity = Vector2.up * JumpForce;
            animator.SetFloat("juu", 5f); 


        }
        else {
            animator.SetFloat("juu", 0);
            
        }
    }
}
