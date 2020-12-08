using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RampDown : MonoBehaviour
{

    private GameObject ramp;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        ramp = GameObject.Find("Ramp");
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

            ramp.SendMessage("Down");
        }
    }
}

