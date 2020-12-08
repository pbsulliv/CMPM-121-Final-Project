using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    public float speed = 0.1f;
    public float open = 0.0f;
    Transform transform;

    // Start is called before the first frame update
    void Start()
    {
        this.transform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Open Door
        /*
        if (open == 1.0f)
        {
            for(int i = 0; i < 20; i++)
            {
                var new_position = transform.position;
                new_position.y += this.speed * Time.deltaTime;
                this.transform.position = new_position;
            }
        }
        */
        /*
        else
        {
            for (int i = 0; i < 20; i++)
            {
                var new_position = transform.position;
                new_position.y -= this.speed * Time.deltaTime;
                this.transform.position = new_position;
            }
        }
        */
    }

    void Open ()
    {
        Debug.Log("open door");
        
        for (int i = 0; i < 20; i++)
        {
            var new_position = transform.position;
            new_position.y += 10 * Time.deltaTime;
            this.transform.position = new_position;
        }
    }
}
