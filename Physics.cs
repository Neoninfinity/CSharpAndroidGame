using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{
    public Transform sphere3D;
    public float ballRadius = 1;
    float c;
    Rigidbody2D rb;
    Vector3 axis;
    float angle;

    void Start()
    {
        c = 2 * Mathf.PI * ballRadius;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        axis = Vector3.Cross(rb.velocity, Vector3.forward);
        angle = (rb.velocity.magnitude * 360 / c);
        sphere3D.Rotate(axis, angle * Time.deltaTime, Space.World);
    }
}