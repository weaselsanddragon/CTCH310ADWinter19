using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicmovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    
    void move()
    {
        /*
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //print("it works");
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //print("it works");
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("it works");
            Vector3 position = this.transform.position;
            position.z++;
            this.transform.position = position;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("it works");
            Vector3 position = this.transform.position;
            position.z--;
            this.transform.position = position;
        }
        */
        Cursor.lockState = CursorLockMode.Locked;
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.1f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f, 0f);
        }
        
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");

        float minR = 360-45;
        float maxR = 45;

        transform.Rotate(-v, h, 0);
        Vector3 currentR = transform.localRotation.eulerAngles;
        //print(currentR.z);
        if (currentR.x > 180)
            currentR.x = Mathf.Clamp(currentR.x, minR, 360);
        if (currentR.x <= 180)
            currentR.x = Mathf.Clamp(currentR.x, 0, maxR);
        if (currentR.z != 0)
            currentR.z = 0;
        transform.localRotation = Quaternion.Euler(currentR);

    }
    
}
