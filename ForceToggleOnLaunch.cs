using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ForceToggleOnLaunch : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        if (PlayerPrefs.HasKey("MenuSound"))
        {

            GameObject MusicTog;
            MusicTog = GameObject.Find("Canvas1/Music");
            if (PlayerPrefs.GetInt("MenuSound") == 1)
            {
                Toggle a;
                a = MusicTog.GetComponent<Toggle>();
                a.isOn = true;
            }
            else
            {
                Toggle a;
                a = MusicTog.GetComponent<Toggle>();
                a.isOn = false;
            }
        }
        else
        {
            PlayerPrefs.SetInt("MenuSound", 1);
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
