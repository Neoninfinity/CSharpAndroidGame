using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class PortalNext : MonoBehaviour
{
    GameObject Summary;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject Summary;
        string time;
        string deaths;
        GameObject timer;
        GameObject ball;
        Summary = GameObject.Find("Canvas").transform.FindChild("Summary").gameObject;
        time = GameObject.Find("Canvas/Timer").GetComponent<Text>().text;
        deaths = GameObject.Find("Canvas/Deaths").GetComponent<Text>().text;
        timer  = GameObject.Find("Canvas/Timer");
        timer.GetComponent<Timer>().enabled = false;
        ball = GameObject.Find("ball");
        ball.GetComponent<New>().speed = 0;
        Summary.SetActive(true);
        GameObject a;
        GameObject b;
        a = Summary.transform.Find("Time").gameObject;
        b = Summary.transform.Find("Deaths").gameObject;
        a.GetComponent<Text>().text = time;
        b.GetComponent<Text>().text = deaths;


        //
    }
}
