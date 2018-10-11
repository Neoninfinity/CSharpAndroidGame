using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    int min;
    int seconds;
    int ms;
    public bool pause;
    GameObject timer;
    // Check the timer then add
    void Check () {
        if (ms >= 60)
        {
            ms = 0;
            seconds++;
            
        }

        else if (seconds >= 60)
        {
            seconds = 0;
            min++;

        }

    }
    // Use this for initialization
    void Start()
    {
        min = 0;
        seconds = 0;
        ms = 0;
        timer = GameObject.Find("Canvas/Timer");
    }



    // Update is called once per frame
    void Update() {
        if (pause == false)
        {
            ms++;
            Check();




            if (ms < 10 | (ms < 10 & seconds < 10) | (ms < 10 & min < 10))
            {
                timer.GetComponent<Text>().text = (min + ":" + "0" + seconds + ":" + "0" + ms);
            }
            else if ((seconds < 10) | (seconds < 10 & ms < 10) | (min < 10 & seconds < 10))
            {
                timer.GetComponent<Text>().text = (min + ":" + "0" + seconds + ":" + ms);
            }
            else if (min < 10 & seconds > 10 & ms > 10)
            {
                timer.GetComponent<Text>().text = ("0" + min + ":" + seconds + ":" + ms);
            }
            else if (ms < 10 & seconds < 10 & min < 10)
            {
                timer.GetComponent<Text>().text = ("0" + min + ":" + "0" + seconds + ":" + "0" + ms);
            }
        }


    }

}
