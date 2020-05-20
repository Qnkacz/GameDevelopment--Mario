using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public Enemy me;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        me.Goright = false;
        me.Goleft = true;
    }
}
