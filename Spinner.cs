using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {
    public int spd;
    int a;
	// Use this for initialization
	void Start () {
        InvokeRepeating("opp", 0, 10);
    }
	
	// Update is called once per frame
	void Update () {
        a++;
        transform.Rotate(0, 0, spd * Time.deltaTime);
    }
    void opp()
    {
    }
}
