using UnityEngine;
using System.Collections;

public class MovingPlat : MonoBehaviour
{
    public int rightLimit = 2;
    public int leftLimit = -2;
    public float speed = 2.0f;
    Vector2 movement;
    private int direction = 1;

    void Update()
    {
        if (transform.position.x > rightLimit)
        {
            direction = -1;
        }
        else if (transform.position.x < leftLimit)
        {
            direction = 1;
        }
        movement = Vector2.right * direction * speed * Time.deltaTime;
        transform.Translate(movement);

    }
}