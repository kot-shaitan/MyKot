using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float JumpForce =  5f;
    // Start is called before the first frame update
    private Rigidbody2D capybara;
    private bool JumpBool = false;
    public float jumphigh = 0f;
    SpriteRenderer capy;
    public Animator animator;
    void Start()
    {
        capybara = gameObject.GetComponent<Rigidbody2D>();
        capy = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            JumpBool = true;
        }
        else {
            JumpBool = false;
        }
    }
    void FixedUpdate()
    {
        if  (JumpBool == true) {
            capybara.velocity = Vector2.up * JumpForce;
            jumphigh = 5f;
        }
        else {
            jumphigh = -5f;
        }
    }

}
