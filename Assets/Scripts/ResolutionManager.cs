using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class ResolutionManager : MonoBehaviour
{
    public int height = 768;
    public int width = 1360;
    public bool fullscreen = false;
    public void Res_set_800()
    {
        height = 600;
        width = 800;
       Screen.SetResolution( width, height, fullscreen);
    }
    public void Res_set_1024()
    {
        height = 768;
        width = 1024;
        Screen.SetResolution(width, height, fullscreen);
    }
    public void Res_set_1280()
    {
        height = 720;
        width = 1280;
        Screen.SetResolution(width, height, fullscreen);
    }
    public void Res_set_1360()
    {
        height = 768;
        width = 1360;
        Screen.SetResolution(width, height, fullscreen);
    }
    public void Res_set_1366()
    {
        height = 768;
        width = 1366;
        Screen.SetResolution(width, height, fullscreen);
    }
    public void Res_set_1920()
    {
        height = 1080;
        width = 1920;
        Screen.SetResolution(width, height, fullscreen);
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void On_Scren()
    {
        Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;

    }
    public void Off_Screen()
    {
        Screen.fullScreenMode = FullScreenMode.Windowed;
    }
    public AudioMixer mixer;

    public void SetLevel(float sliderValue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
}
