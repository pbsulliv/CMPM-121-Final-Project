using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code from:
//https://gamedevacademy.org/unity-3d-first-and-third-person-view-tutorial/

public class CameraControl : MonoBehaviour
{
    public float minTurnAngle = -90.0f;
    public float maxTurnAngle = 90.0f;
    public float turnSpeed = 3.0f;
    private float rotX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MouseControl();
    }

    void MouseControl()
    {
        float y = Input.GetAxis("Mouse X") * turnSpeed;
        rotX += Input.GetAxis("Mouse Y") * turnSpeed;

        rotX = Mathf.Clamp(rotX, minTurnAngle, maxTurnAngle);

        transform.eulerAngles = new Vector3(-rotX, transform.eulerAngles.y + y, 0);
    }

}
