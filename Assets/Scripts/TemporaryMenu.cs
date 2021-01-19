using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TemporaryMenu : MonoBehaviour
{
    // Start is called before the first frame updates
    public bool really;
    public GameObject Button_A;
    public GameObject Button_B;
    public GameObject Button_C;
    public GameObject Button_D;
    public GameObject GI;
    public Image GI2;


    void Start()
    {
        really = false;
        Button_A = GameObject.Find("A");
        Button_B = GameObject.Find("B");
        Button_C = GameObject.Find("C");
        Button_D = GameObject.Find("D");
        GI = GameObject.Find("Imagus");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void A_Click()
    {
        GI.SetActive(!GI.activeSelf);
        return;
        //Close all other images by
        //Close.all.bythis.nametag("MenuImage");
        
    }
    public void B_Click()
    {

    }
    public void C_Click()
    {


    }
    public void D_Click()
    {

    }
}
