using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCamera : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Camera.main.transform,Vector3.up);
        //transform.eulerAngles = new Vector3(0,transform.eulerAngles.y,0);
    }
}
