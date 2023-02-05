using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public GameObject rotationTarget;
    public float rotationSpeed = 2f;
    public float riseSpeed = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Delay function by 30 seconds
        if (Time.time > 30)
        {
            RotateCameraAroundObject();
        }
        if (Time.time > 45)
        {
            ZoomOut();
        }
    }

    void RotateCameraAroundObject()
    {
        //transform.LookAt(rotationTarget.transform);
        transform.RotateAround(rotationTarget.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
    void ZoomOut()
    {
        transform.Translate(Vector3.up * riseSpeed * Time.deltaTime);
        transform.Translate(Vector3.forward * riseSpeed * -0.3f * Time.deltaTime);
    }

}
