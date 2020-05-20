using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    // Start is called before the first frame update
    Player player;
    
    void Start()
    {
        player = gameObject.transform.parent.gameObject.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D collision)
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
