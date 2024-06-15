using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public float gravity = -1f;
    public float jumpHeight = 2f;
    public float groundDistance = 10f;
    public Transform groundChck;
    public LayerMask groundMask;
    public Vector3 velocity;
    public Vector3 lastPosition = new(0f,0f,0f);
    public bool isGrounded; 
    public bool isMoving;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundChck.position,groundDistance,groundMask);
        if(isGrounded &&velocity.y<0){
            velocity.y = -1;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right*x+transform.forward*z;
        controller.Move(speed*Time.deltaTime*move);
        if(Input.GetKeyDown(KeyCode.Space)&&isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight*-1f*gravity);
        }
        velocity.y += gravity*Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
        if (lastPosition!= transform.position&isGrounded){
            isMoving = true;
        }
        else {
            isMoving = false;
        }
        lastPosition = transform.position;
    }
}
