using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(GravityGun))]
[RequireComponent(typeof(PlayerController))]
public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    PlayerController _playerController;
    [SerializeField]
    GravityGun _gravityGun;
    [SerializeField]
    CharacterController _characterController;

    // Use this for initialization
    void Start()
    {
        _playerController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {


        GravityGunUpdate();
        MovementUpdate();
    }

    void MovementUpdate()
    {
        Vector3 movement = Vector3.zero;
        if (_characterController.isGrounded)
        {
            movement = Vector3.zero;
        }

        //changes to speed caused by the gravity gun or other factors besides player input/default gravity go here


        _playerController.Control(movement);
    }

    void GravityGunUpdate()
    {

        if (Input.GetMouseButtonDown(0))
        {
            _gravityGun.pull = true;
            _gravityGun.isCasting = true;
            _gravityGun.CastGravity();
        }
        else
        {
            _gravityGun.isCasting = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            _gravityGun.pull = false;
            _gravityGun.isCasting = true;
            _gravityGun.CastGravity();
        }
        else
        {
            _gravityGun.isCasting = false;
        }

    }

}
