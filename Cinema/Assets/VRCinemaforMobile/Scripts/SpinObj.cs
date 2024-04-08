using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObj : MonoBehaviour
{
    public float rotationleft = 360;
    public float rotationSpeed = 10;
    public float rotation;
    public bool stop;

    void Start()
    {
        
    }
    
    void Update()
    {
        //float rotation = rotationSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            rotation = -rotationSpeed * Time.deltaTime;
            transform.Rotate(0, rotation, 0);
            transform.position = transform.position + new Vector3(rotation*0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rotation = rotationSpeed * Time.deltaTime;
            transform.Rotate(0, rotation, 0);
            transform.position = transform.position + new Vector3(rotation*0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rotation = rotationSpeed * Time.deltaTime;
            transform.Rotate(-rotation, 0, 0);
            transform.position = transform.position + new Vector3(0, rotation*0.1f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotation = -rotationSpeed * Time.deltaTime;
            transform.Rotate(-rotation, 0, 0);
            transform.position = transform.position + new Vector3(0, rotation*0.1f, 0);
        } 
    }
}
