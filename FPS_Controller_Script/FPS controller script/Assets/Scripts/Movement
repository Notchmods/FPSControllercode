using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0f, 0f, -5f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(5f, 0f, 0f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0f, 0f, 5f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(-5f, 0f, 0f * Time.deltaTime);
        }
    }
}
