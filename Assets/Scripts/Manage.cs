using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Manage : MonoBehaviour
{
    // Start is called before the first frame update
    //public string sceneX="SettingsMenu";
    public void Start_Button()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Load_Button()
    {
        //Nothing Happens
    }
    public void Settings_Button()
    {
        SceneManager.LoadScene("SettingsMenu");
        //SceneManager.LoadScene(sceneX);
    }
    public void Exit_Button()
    {
        Application.Quit();
    }
}
