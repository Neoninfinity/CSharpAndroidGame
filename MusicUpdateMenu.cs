using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MusicUpdateMenu : MonoBehaviour {
    bool Trigger;
    static bool AudioBegin = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject MusicTog = GameObject.Find("Canvas1/Music");
        Toggle a = MusicTog.GetComponent<Toggle>();
        if (PlayerPrefs.GetInt("MenuSound") == 0 & Trigger == false)
        {
            Trigger = true;
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().mute = true;
            AudioBegin = true;
        }
        else if (PlayerPrefs.GetInt("MenuSound") == 1 & Trigger == true | SceneManager.GetActiveScene().name != "Menu")
        {
            GetComponent<AudioSource>().Play();
            GetComponent<AudioSource>().mute = false;
            AudioBegin = false;
            Trigger = false;
        }
    }
}
