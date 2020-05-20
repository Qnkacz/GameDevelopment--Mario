using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool grounder = false;
    public float jumpForce;
    public float maxspeed;
    
    void LateUpdate()
    {
        Jump();
        if(Input.GetKey(KeyCode.D))
        {
         rb.AddForce(new Vector2(5f, 0), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-5f, 0), ForceMode2D.Force);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="enemy")
        {
            boss.bs.GameOver();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            boss.bs.GameOver();
        }
        if(collision.gameObject.tag=="Finish")
        {
            boss.bs.Victory();
        }
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
   
    public static void GameOver()
    {
        Time.timeScale = 0;
    }
}
