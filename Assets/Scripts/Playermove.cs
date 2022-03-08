using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float JumpForce = 10f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            rb.velocity = new Vector2(-MoveSpeed, rb.velocity.Y);
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector2(rb.velocity.X, JumpForce);
        }
        if (Input.GetKeyDown(KeyCode.D)){
            rb.velocity = new Vector2(MoveSpeed, rb.velocity.Y);
        }
    }
}
