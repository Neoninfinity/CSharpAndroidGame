using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
public class Deaths : MonoBehaviour {
    public int deaths;
    GameObject d;
	// Use this for initialization
	void Start () {
        d = GameObject.Find("Canvas/Deaths");

    }
	
	// Update is called once per frame
	void Update () {
        {
            d.GetComponent<Text>().text = ""+(deaths);
        }
	}
}
