using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float targetTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveCameraOnXOverTime();
        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void MoveCameraOnXOverTime()
    {
        transform.position = new Vector3(transform.position.x + (0.5f * Time.deltaTime), transform.position.y, transform.position.z);
    }
        
        
    void timerEnded()
    {
            transform.position = new Vector3(transform.position.x , transform.position.y + (0.5f * Time.deltaTime),  transform.position.z);
     }
}
