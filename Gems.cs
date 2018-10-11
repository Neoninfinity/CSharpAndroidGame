using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Gems : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int a;
        a = PlayerPrefs.GetInt("Gems");
        GetComponent<Text>().text = "" + a;

	}
}
