using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameChangeMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Counter Location
        GameObject counter;
        int num;
        counter = GameObject.Find("Canvas1/Items");
        num = counter.GetComponent<Drag>().counter;
        //Text Location
        GameObject a;
        string b;
        a = GameObject.Find("Canvas1/Name");
        b = a.GetComponent<Text>().text;
        if (num == 1)
        {
            a.GetComponent<Text>().text = ("Load Game");
        }
        else if (num == 2)
        {
            a.GetComponent<Text>().text = ("New Game");
        }
        else if (num == 3)
        {
            a.GetComponent<Text>().text = ("Shop");
        }
        else if (num == 4)
        {
            a.GetComponent<Text>().text = ("Settings");
        }



	}
}
