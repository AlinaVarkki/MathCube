using System;
using UnityEngine;
using UnityEngine.UI;

public class SoundOff : MonoBehaviour
{

    public GameObject cross;
    public AudioSource click;
    public Button soundButton;

    public bool soundOn = true;


    public void Update()
    {
        cross.SetActive(!Boolean.Parse(PlayerPrefs.GetString("soundBool", "true")));
    }

    public void SoundOnClick()
    {
        
        Toggle();
    }

    public void Toggle()
    {

        click.Play();
        

        //change sound state 
        AudioListener.pause = soundOn;
        
        soundOn = !soundOn;
        PlayerPrefs.SetString("soundBool", soundOn.ToString());

    }


    }
