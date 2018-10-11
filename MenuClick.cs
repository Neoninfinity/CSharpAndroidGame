using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MenuClick : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
        PlayerPrefs.SetInt("level", 1);
        PlayerPrefs.Save();
    }
    public void LoadGame()
    {
        if (PlayerPrefs.GetInt("level") > 0)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("level"));
        }
        else
        {
            PlayerPrefs.SetInt("level", 1);
            PlayerPrefs.Save();
        }
    }
    public void MusicOff()
    {
        Toggle a;
        GameObject MusicTog;
        MusicTog = GameObject.Find("Canvas1/Music");
        a = MusicTog.GetComponent<Toggle>();

        if (a.isOn == true)
        {
            PlayerPrefs.SetInt("MenuSound", 1);
            PlayerPrefs.Save();

        }
        else if (a.isOn == false)
        {
            PlayerPrefs.SetInt("MenuSound", 0);
            PlayerPrefs.Save();
        }
    }
}
