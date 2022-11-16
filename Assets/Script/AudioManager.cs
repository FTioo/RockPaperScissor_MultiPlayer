using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider SFXSlider;
    public Slider BGMSlider;
    public AudioMixer mixer;

    public void Start() {
        float db;
        if (SFXSlider == null)
            return;
        if (BGMSlider == null)
            return;

        if (mixer.GetFloat("SFX_Volume", out db))
            SFXSlider.value = (db+80)/80;    

        if (mixer.GetFloat("BGM_Volume", out db))
            SFXSlider.value = (db+80)/80;    
    }

    public void SFXVolume(float value){
        value = value*80 - 80;

        mixer.SetFloat("SFX_Volume",value);
        Debug.Log((value+80)/.8f);
    }
    public void BGMVolume(float value){
        value = value*80 - 80;

        mixer.SetFloat("BGM_Volume",value);
        Debug.Log((value+80)/.8f);
    }
    public void muteToggle(bool Muted){
        if (Muted){
            AudioListener.volume = 0;
            Debug.Log("Muted");
        }
        else{
            AudioListener.volume = 1;
            Debug.Log("Unmuted");
        }

    }
}
