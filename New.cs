using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New : MonoBehaviour {
    public Rigidbody2D rb;
    public float speed;
    public float torque;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
            //var a = Input.acceleration.x * .5;
            Vector2 dir = Vector2.zero;
            dir.y = Input.acceleration.y;
            dir.x = Input.acceleration.x;
            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            dir *= Time.deltaTime;
          //  rb.AddTorque(dir.x * speed);
            transform.Translate(dir * speed);


    }
}
