using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    // Start is called before the first frame update
    public Player player;
   
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "brick")
        {
            player.grounder = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "floor" || collision.gameObject.tag == "brick")
        {
            player.grounder = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
         if(collision.gameObject.tag=="floor" || collision.gameObject.tag == "brick")
        {
            player.grounder = false;
        }
    }
}
