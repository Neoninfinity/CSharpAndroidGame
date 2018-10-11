using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Click : MonoBehaviour
{
    public bool triggered;
    public bool setTrig;
    public void Animate()
    {
        bool complete;
        complete = GameObject.Find("Canvas").transform.FindChild("Summary").gameObject.activeSelf;
        if (triggered == false & complete == false)
        {
            GameObject timer;
            GameObject a;
            GameObject b;
            GameObject ball;
            GameObject.Find("Canvas").transform.FindChild("Shard").gameObject.SetActive(true);
            a = GameObject.Find("Canvas/Image");
            b = GameObject.Find("Canvas/Image2");
            timer = GameObject.Find("Canvas/Timer");
            timer.GetComponent<Timer>().pause = true;
            Animation ani1 = a.GetComponent<Animation>();
            Animation ani2 = b.GetComponent<Animation>();
            ani1["HomeButton"].speed = 1;
            ani2["Cog"].speed = 1;
            ani1.Play();
            ani2.Play();

            ball = GameObject.Find("ball");
            ball.GetComponent<New>().speed = 0;
            triggered = true;
        }
        else if (triggered == true & setTrig == false & complete == false)
        {
            GameObject timer;
            GameObject a;
            GameObject b;
            GameObject ball;
            a = GameObject.Find("Canvas/Image");
            b = GameObject.Find("Canvas/Image2");
            GameObject.Find("Canvas/Shard").SetActive(false);
            Animation ani1 = a.GetComponent<Animation>();
            Animation ani2 = b.GetComponent<Animation>();
            ani1["HomeButton"].speed = -1;
            ani1["HomeButton"].time = ani1["HomeButton"].length;
            ani2["Cog"].speed = -1;
            ani2["Cog"].time = ani2["Cog"].length;
            ani1.Play();
            ani2.Play();
            ball = GameObject.Find("ball");
            ball.GetComponent<New>().speed = 10;
            timer = GameObject.Find("Canvas/Timer");
            timer.GetComponent<Timer>().pause = false;
            triggered = false;
        }
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void settings()
    {
        GameObject a;
        GameObject b;
        GameObject c;
        a = GameObject.Find("Canvas/Image");
        b = GameObject.Find("Canvas/Image2");
        Animation ani1 = a.GetComponent<Animation>();
        Animation ani2 = b.GetComponent<Animation>();
        ani1["HomeButton"].speed = -1;
        ani1["HomeButton"].time = ani1["HomeButton"].length;
        ani2["Cog"].speed = -1;
        ani2["Cog"].time = ani2["Cog"].length;
        ani1.Play();
        ani2.Play();
        c = GameObject.Find("Canvas/Settings");
        Animation ani3 = c.GetComponent<Animation>();
        ani3["SettingsiN"].speed = 1;
        ani3.Play();
        setTrig = true;
    }
    public void settingout()
    {
        GameObject a;
        GameObject b;
        GameObject c;
        a = GameObject.Find("Canvas/Image");
        b = GameObject.Find("Canvas/Image2");
        c = GameObject.Find("Canvas/Settings");
        Animation ani1 = a.GetComponent<Animation>();
        Animation ani2 = b.GetComponent<Animation>();
        Animation ani3 = c.GetComponent<Animation>();
        ani3["SettingsiN"].speed = -1;
        ani3["SettingsiN"].time = ani3["SettingsiN"].length;
        ani3.Play();
        ani1["HomeButton"].speed = 1;
        ani2["Cog"].speed = 1;
        ani1.Play();
        ani2.Play();
        setTrig = false;
    }

    public void loadsaveHome()
    {

        PlayerPrefs.SetInt("level", (SceneManager.GetActiveScene().buildIndex+1));
        PlayerPrefs.Save();
        SceneManager.LoadScene("Menu");
    }
    public void nextlevelsave()
    {
        PlayerPrefs.SetInt("level", (SceneManager.GetActiveScene().buildIndex+1));
        PlayerPrefs.Save();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}