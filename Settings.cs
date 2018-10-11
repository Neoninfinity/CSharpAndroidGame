using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour {
    void Start()
    {
        if (PlayerPrefs.HasKey("Sound")){

            GameObject MusicTog;
            MusicTog = GameObject.Find("Canvas/Settings/Music");
            if (PlayerPrefs.GetInt("Sound") == 1)
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
            PlayerPrefs.SetInt("Sound", 1);
        }

    }


    public void musicOn()
    {
        Toggle a;
        GameObject MusicTog;
        MusicTog = GameObject.Find("Canvas/Settings/Music");
        a = MusicTog.GetComponent<Toggle>();
        
        if (a.isOn == true)
        {
            PlayerPrefs.SetInt("Sound", 1);
            PlayerPrefs.Save();

        }
        else if (a.isOn == false)
        {
            PlayerPrefs.SetInt("Sound", 0);
            PlayerPrefs.Save();
        }
    }
}
