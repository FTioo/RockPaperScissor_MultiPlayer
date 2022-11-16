using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Resolution : MonoBehaviour
{
    public TMP_Dropdown reso;

    public void resolution(){
        switch(reso.value){
            case 0:
                Screen.SetResolution(640,360, false);
                Debug.Log("640 x 360");
                break;
            case 1:
                Screen.SetResolution(1024,768, false);
                Debug.Log("1024 x 768");
                break;
            case 2:
                Screen.SetResolution(1280,720, false);
                Debug.Log("1280 x 720");
                break;
            case 3:
                Screen.SetResolution(1920,1080, false);
                Debug.Log("1920 x 1080");
                break;
        }
    }
}
