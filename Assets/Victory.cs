using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public GameObject GO;

    // Start is called before the first frame update
    void Start()
    {
        GO = GameObject.Find("Victory (TMP)");
        GO.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void won()
    {
        GO.SetActive(true);
    }
}
