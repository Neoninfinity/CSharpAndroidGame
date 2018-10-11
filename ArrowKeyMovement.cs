using UnityEngine;
using System.Collections;

public class ArrowKeyMovement : MonoBehaviour {
    public Rigidbody2D rb;
    public float movespeed;

    void Start() {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update(){

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(movespeed, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            System.Console.WriteLine("UpArrow");
            rb.velocity = new Vector2(-movespeed, rb.velocity.y);
        }
    }
}
