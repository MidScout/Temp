using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour {

    //public float movespeed;
    // Use this for initialization
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
        //float MoveH = Input.GetAxis("Horizontal");
        //float MoveV = Input.GetAxis("Vertical");
        //transform.Translate(new Vector3(MoveH, 0, MoveV) * Time.deltaTime * movespeed);    //按水平或者垂直的方向键，                                                                                                                                              就怎么移动
        //if (Input.GetButton("Jump"))
        //{
        //    Rigidbody r = GetComponent<Rigidbody>();
        //    r.AddForce(new Vector3(0, 0.5f, 0), ForceMode.Impulse);
        //
}
