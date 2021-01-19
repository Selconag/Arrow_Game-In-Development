using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera_hareketi : MonoBehaviour
{
    float X_mouse, Y_mouse;
    float speed = 1.0f;
    float high_speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        X_mouse = Input.GetAxis("Mouse Y");
        Y_mouse = Input.GetAxis("Mouse X");
        transform.Rotate(-X_mouse,0,0 );
        transform.Rotate(0, Y_mouse, 0,Space.World);
        //RIGHT MOVE
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
           transform.Translate(new Vector3(high_speed * Time.deltaTime, 0, 0));
        }
        if (!(Input.GetKey(KeyCode.LeftShift)) && (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        //LEFT MOVE
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
        {
            transform.Translate(new Vector3(-high_speed * Time.deltaTime, 0, 0));
        }
        if (!(Input.GetKey(KeyCode.LeftShift)) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        //BACKWARD MOVE
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            transform.Translate(new Vector3(0, 0, -high_speed * Time.deltaTime));
        }
        if (!(Input.GetKey(KeyCode.LeftShift)) && (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)))
        {
            transform.Translate(new Vector3(0, 0, -speed * Time.deltaTime));
        }
        //FORWARD MOVE
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            transform.Translate(new Vector3(0, 0, high_speed * Time.deltaTime));
        }
        if (!(Input.GetKey(KeyCode.LeftShift)) && (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)))
        {
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }

    }
}
