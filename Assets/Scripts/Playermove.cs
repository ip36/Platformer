using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public float JumpForce = 10f;
    public Rigidbody2D rb;
    public Collider2D collider;
    public Collider2D feet;
    public int maxJumps = 2;
    private int jumpsLeft;
    // Start is called before the first frame update
    void Start()
    {
        jumpsLeft = maxJumps;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpsLeft > 0){
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            jumpsLeft -= 1;
        }
        float inputX = Input.GetAxis("Horizontal");
        Vector3 direction = new Vector3(MoveSpeed*inputX, rb.velocity.y, 0);
        transform.Translate(direction*Time.deltaTime);
    }
    void OnCollisionEnter(Collision c){
        jumpsLeft = maxJumps;
        Debug.Log("bgcrfeuvbreicfbnw");
    }
}
