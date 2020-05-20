using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roof : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.GetComponent<SpriteRenderer>().color = new Color(246f, 200f, 133f);
    }
}
