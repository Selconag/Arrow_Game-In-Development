using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class yonetici : MonoBehaviour
{
    public Transform Main;
    public GameObject ok;
    public Transform hedef_pos;
    public int first_pos_change = 7;
    public int difference;
    public int pos_change;
    float guc = 4000;
    float reset_guc = 4000;
    public Transform kamera;
    public Image Atishizibari;
    int puan;
    public Text Puanlar;
    bool spawn = false;

    //yeni eklenecek
    float chargeLevel = 0; //Don't change this in the inspector.
    float chargeSpeed = 0.1f; //Default, the charge will go up 1 per second
    bool isCharging = false;

    void Start()
    {
        kamera = GameObject.Find("Main Camera").transform;
        hedef_pos = GameObject.Find("hedef").transform;
        Main = kamera;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ok_Hazırla();
            //GameObject yeni_ok = Instantiate(ok, kamera.position, kamera.rotation);                  //Burada kamera.position diyerek kameranın o anki konumu , kamera.rotation diyerek kameranın o anki açısına göre bir obje oluşturduk(ok).
            //guc *= Atishizibari.fillAmount;                                                         //Burada bar ile orantılı bir şekilde atış gücünü çarparak yeni atışhizini bulduk.
            //yeni_ok.GetComponent<Rigidbody>().AddForce(yeni_ok.transform.forward * guc);            //Burada objeye güç verilerek foward ile rotasyonu bozulmadan hareket ettirilmesini sağlamış olduk.
            //guc = reset_guc;
            //Destroy(yeni_ok, 4.0f);                  //Burada kamera.position diyerek kameranın o anki konumu , kamera.rotation diyerek kameranın o anki açısına göre bir obje oluşturduk(ok).
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            //SceneManager.LoadScene("SettingsMenu");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {

        }
    }

    public void puan_artis(int deger)
    {
        if (kamera.position.z != Main.position.z)
        {
            puan = puan + deger + (int)(Main.position.z - pos_change * (-1));
            Puanlar.text = puan.ToString();
        }
        else
        {
            puan += deger;
            Puanlar.text = puan.ToString();
        }

    }
    public int uzaklik_hesaplama()
    {
        pos_change = ((int)(hedef_pos.position.z - kamera.position.z));
        //difference = (int)(Main.position.z - pos_change * (-1));
        difference = pos_change - first_pos_change;
        return difference;
    }
    public void CalculateCharge()
    {
     chargeLevel += Time.deltaTime * chargeSpeed;
    }
    public void Ok_Hazırla()
    {
        if (spawn == false)
        {
            GameObject yeni_ok = Instantiate(ok, kamera.position, kamera.rotation);
            spawn = true;
            while (Input.GetMouseButtonDown(0))
            {
                guc *= Time.deltaTime * chargeSpeed;
            }
            yeni_ok.GetComponent<Rigidbody>().AddForce(yeni_ok.transform.forward * guc);
            guc = reset_guc;
            spawn = false;
            Destroy(yeni_ok, 4.0f);
        }
        else
        {
            //nothing happens
        }
    }
}
