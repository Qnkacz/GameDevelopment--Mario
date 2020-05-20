using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Rootparent;
    public Rigidbody2D rb;
    public bool Goright=true;
    public bool Goleft = false;
    private void Start()
    {
        Rootparent = this.gameObject.transform.parent.gameObject;
        rb = Rootparent.GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(Rootparent);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(Rootparent);
        }
    }
    private void LateUpdate()
    {
        
        if (Goright)
        {
            rb.AddForce(new Vector2(5f, 0), ForceMode2D.Impulse);
            if (rb.velocity.x > 5)
            {
                rb.velocity = new Vector2(5, 0);
            }
        }
        if(Goleft)
        {
            rb.AddForce(new Vector2(-5f, 0), ForceMode2D.Impulse);
            if (rb.velocity.x < -5)
            {
                rb.velocity = new Vector2(-5, 0);
            }
        }
    }
}
