using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BorderTeleport : MonoBehaviour {
    public BoxCollider2D ch;
    public Vector2 spawn;
    public GameObject ball;
    GameObject deathloc;
    GameObject powerups;
    int deaths;
    GameObject sound;
    void Start()
    {
        spawn = GameObject.Find("Crosshair").transform.position;
        ball = GameObject.Find("ball");
    }

    void Update()
    {
        
        }
    void OnTriggerEnter2D(Collider2D other)
    {
        Singleton.Instance.Death();
    }

}
