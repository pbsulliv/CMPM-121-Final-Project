using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour
{
    Transform transform;


    // Start is called before the first frame update
    void Start()
    {
        this.transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Down()
    {
        //Rotation
        var new_rotation = this.transform.localRotation;
        new_rotation = Quaternion.Euler(-30.0f, 0.0f, 0.0f) * new_rotation;
        this.transform.localRotation = new_rotation;
    }
}
