using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitenemy : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag=="enemy")
        {
            Debug.Log("boing");
            boss.bs.GameOver();
        }
        if(collision.collider.tag=="todestroy")
        {
            Destroy(collision.gameObject);
        }
    }
}
