using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryTrigger : MonoBehaviour
{
    private GameObject txt;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        txt = GameObject.Find("Victory (TMP)");
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

            txt.SendMessage("won");
        }
    }
}
