using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float speed = 8.0f;

    public float distance = 100.0f;

    public Text score;

    public int score_number = 0;

    Vector3 facing_direction;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //Character Controller
        
        var characterController = this.GetComponent<CharacterController>();
        characterController.SimpleMove(new Vector3(
            this.speed * Input.GetAxis("Horizontal"),
            0.0f,
            this.speed * Input.GetAxis("Vertical")
        ));
        

        /*
        if (Input.GetKey("w"))
        {
            facing_direction = Camera.main.transform.forward;
            facing_direction.y = 0;
            transform.position = transform.position + facing_direction * distance * Time.deltaTime;

        }
        */
    }

}
