using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsTXT : MonoBehaviour
{
    public GameObject GO;

    // Start is called before the first frame update
    void Start()
    {
        GO = GameObject.Find("Controls (TMP)");
        GO.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            GO.SetActive(false);
        }
    }
}
