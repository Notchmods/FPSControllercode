using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float Vertical;
    float Horizontal;
    public Transform Maincamera;
    // Start is called before the first frame update
    void Start()
    {
        if(Time.timeScale == 1)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vertical = Input.GetAxis("Vertical");
        Horizontal = Input.GetAxis("Horizontal");
        Vector3 CamF = Maincamera.forward;
        Vector3 CamR = Maincamera.right;
        CamF.y = 0f;
        CamR.y = 0f;
        var Movement = Vertical * CamF + Horizontal * CamR;
        transform.Translate(Movement * 15f * Time.deltaTime);
        if(transform.position.y < 1f)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                transform.Translate(0f, 5f, 0f * Time.deltaTime);
            }
        }

    }
}
