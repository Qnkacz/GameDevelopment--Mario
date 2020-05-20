using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveRight : MonoBehaviour
{
    public Enemy me;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        me.Goleft = false;
        me.Goright = true;
    }
}
