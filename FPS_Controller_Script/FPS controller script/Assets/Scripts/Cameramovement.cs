using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramovement : MonoBehaviour
{
    float Vertical;
    float Horizontal;
    public float Sensitivity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vertical += Sensitivity * Input.GetAxis("Mouse X");
        Horizontal -= Sensitivity * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(Horizontal,Vertical,0f);
    }
}
