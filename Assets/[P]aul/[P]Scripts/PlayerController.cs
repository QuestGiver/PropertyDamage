using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;
    [SerializeField]
    private CharacterController controller;
    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Time.timeScale * 3.5f);
        transform.Rotate(Vector3.left * Input.GetAxis("Mouse Y") * Time.timeScale * 3.5f);
    }

    public void Control(Vector3 move)
    {



        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection) + move;
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }


}
