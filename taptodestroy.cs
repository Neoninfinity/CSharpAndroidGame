using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taptodestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject a;
        if (Input.touchCount > 0)
        {
            Debug.Log("TAP");
            Debug.Log("Touch detected.");
            a = GameObject.Find("ClickToStart/Image");
            Destroy(a);
        }
    }
}
