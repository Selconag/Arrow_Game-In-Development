using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok : MonoBehaviour
{
    Rigidbody rigi;
    BoxCollider box;
    yonetici yonet;
    void Start()
    {
        rigi = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
        yonet = GameObject.Find("yonetici").GetComponent<yonetici>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit temas;
        int hesap = yonet.uzaklik_hesaplama();
        if (Physics.Raycast(transform.position,transform.forward,out temas, 3.0f))
        {
            string isim = temas.collider.gameObject.name;
            if(isim == "sari")
            {
                yonet.puan_artis(12 + hesap);
            }
            else if (isim == "kirmizi")
            {
                yonet.puan_artis(10 + hesap);
            }
            else if (isim == "mavi")
            {
                yonet.puan_artis(8 + hesap);
            }
            else if (isim == "siyah")
            {
                yonet.puan_artis(6 + hesap);
            }
            Sil();
        }
    }
   void Sil()
    {
        Destroy(rigi);
        Destroy(box);
        Destroy(this);
    }
}
