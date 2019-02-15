using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float move;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "player")
        {
            move = -0.3f;
        }
    }
    void Start()
    {
        move = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(move, 0));
    }
}
