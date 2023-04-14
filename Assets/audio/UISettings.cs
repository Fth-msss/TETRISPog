using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class UISettings : MonoBehaviour
{
    [SerializeField]
    GameObject settingspage;

    [SerializeField]
    GameObject gameaudio;

    [SerializeField]
    AudioMixer audiomixer;


    bool ismusicmuted=false;
    bool isaudiomuted=false;
    bool issettingsmenuopen=false;

    public void SettingsButton() 
    {
       

        settingspage.SetActive(!settingspage.activeSelf);
        issettingsmenuopen = !issettingsmenuopen;

        if (issettingsmenuopen) { Time.timeScale = 0; }
        else  { Time.timeScale = 1; }
    }

    public void MuteAudio() 
    {
        if (isaudiomuted) { audiomixer.SetFloat("sfxvolume", 0);  }
        else { audiomixer.SetFloat("sfxvolume", -80); }

        isaudiomuted = !isaudiomuted;
    }

    public void MuteMusic() 
    {
        if (ismusicmuted) { audiomixer.SetFloat("musicvolume", 0); }
        else { audiomixer.SetFloat("musicvolume", -80); }

        ismusicmuted = !ismusicmuted;
    }

    //lets add a slider for "fun"


    public void SetVolume(float sliderValue) {


        audiomixer.SetFloat("mastervolume",sliderValue);

    }


}
