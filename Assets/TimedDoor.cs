using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDoor : MonoBehaviour
{

    public float speed = 0.1f;
    public float time = 0.0f;
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        this.transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //increment time
        time = time + (2.0f * Time.deltaTime);
        Debug.Log(time);

        //open door
        if ((time > 6.0f) && (time < 10.0f))
        {
            OpenDoor();
        }

        //close door
        if ((time > 16.0f) && (time < 20.0f))
        {
            CloseDoor();
        }

        //reset time
        if(time > 20.0f)
        {
            time = 0.0f;
        }
    }

    void OpenDoor()
    {
        Debug.Log("open timed door");

        for (int i = 0; i < 10; i++)
        {
            var new_position = transform.position;
            new_position.y += 10 * Time.deltaTime;
            this.transform.position = new_position;
        }
    }

    void CloseDoor()
    {
        Debug.Log("close timed door");

        for (int i = 0; i < 10; i++)
        {
            var new_position = transform.position;
            while(new_position.y > -0.24f)
            {
                new_position.y -= 5 * Time.deltaTime;
            }
            this.transform.position = new_position;
        }
    }
}
