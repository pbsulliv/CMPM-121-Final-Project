using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof(Rigidbody))]
public class Storage : MonoBehaviour
{
    public float speed = 8.0f;
    public float jumpForce = 2.0f;
    public bool isGrounded;
    //Rigidbody rb;
    Vector3 facing_direction = new Vector3(0.0f, 0.0f, 1.0f);
    public Vector3 jump;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {

        //Character Controller
        var characterController = this.GetComponent<CharacterController>();
        var direction = new Vector3(
            Input.GetAxis("Horizontal"),
            0.0f,
            Input.GetAxis("Vertical")
        );

        //makes it so going diaganol isn't faster
        direction = direction.normalized;
        var delta = direction * this.speed;
        characterController.SimpleMove(delta);

        /*
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {

            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        */

        //make character face current movement direction
        var mix = 0.9f;
        facing_direction = mix * this.facing_direction + (1.0f - mix) * direction;
        //does the same thing
        facing_direction = Vector3.Lerp(direction, this.facing_direction, 0.9f);
        var transform = this.GetComponent<Transform>();
        var target = transform.position + facing_direction;
        transform.LookAt(target);
    }
}
