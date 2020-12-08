using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{

    private GameObject door;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        door = GameObject.Find("Door");
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("collide");
            Object.Destroy(this.gameObject, 0.0f);

            door.SendMessage("Open");

            /*
            if(this.wasPickedUp == true)
            {
                this.score_number += 1;
                this.score.text = "Score: " + this.score_number.ToString();
            }
            */
        }
    }
}
