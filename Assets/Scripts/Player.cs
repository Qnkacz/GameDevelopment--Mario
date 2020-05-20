using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public BoxCollider2D BodyCollider;
    public bool grounder = false;
    public float jumpForce;
    public float maxspeed;
    public bool goingRight;
    
    void Update()
    {
        Jump();
        move();
    }
    void Jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(grounder==true)
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }
    }
    public void move()
    {
        if (rb.velocity.x > 0) goingRight = true;
        else goingRight = false;
        if (Input.GetKey(KeyCode.D))
        {
            
            if(grounder==false && goingRight==false)
            {
                rb.AddForce(new Vector2(25f, 0), ForceMode2D.Force);
            }
            else
            {
                rb.AddForce(new Vector2(5f, 0), ForceMode2D.Force);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (grounder == false && goingRight == true)
            {
                rb.AddForce(new Vector2(-25f, 0), ForceMode2D.Force);
            }
            else
            {
                rb.AddForce(new Vector2(-5f, 0), ForceMode2D.Force);
            }
        }
    }
}
