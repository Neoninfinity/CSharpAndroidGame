using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLeftRight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void left()
    {
        Debug.Log("Left");
        int counter;
        counter = GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter;
        Animation ani1 = GameObject.Find("Canvas1/Items").GetComponent<Animation>();

        if (counter == 4)
        {
            GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter = GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter - 1;
            ani1["Play2"].speed = -1;
            ani1["Play2"].time = ani1["Play2"].length;
            ani1.Play("Play2");
        }
        else if (counter == 3)
        {
            GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter = GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter - 1;
            ani1["Play1"].speed = -1;
            ani1["Play1"].time = ani1["Play1"].length;
            ani1.Play("Play1");
        }
        else if (counter == 2)
        {
            GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter = GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter - 1;
            ani1["Play3"].speed = -1;
            ani1["Play3"].time = ani1["Play3"].length;
            ani1.Play("Play3");
        }
        else
        {
            //If on 4th icon and left swipe
        }

    }
    public void Right()
    {

        int counter;
        counter = GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter;
        Animation ani1 = GameObject.Find("Canvas1/Items").GetComponent<Animation>();
        if (counter > 0)

        {

        }
        else
        {
            GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter = 1;
        }
        if (counter == 1)
        {
            GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter = GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter + 1;
            ani1["Play3"].speed = 1;
            ani1.Play("Play3");
        }
        else if (counter == 2)
        {
            GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter = GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter + 1;
            ani1["Play1"].speed = 1;
            ani1.Play("Play1");
        }
        else if (counter == 3)
        {
            GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter = GameObject.Find("Canvas1/Items").GetComponent<Drag>().counter + 1;
            ani1["Play2"].speed = 1;
            ani1.Play("Play2"); ;
        }
        else
        {
        }
    }
}
