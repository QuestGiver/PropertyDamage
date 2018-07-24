using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterScript : MonoBehaviour
{
    public float impactThreshhold;

    private bool _isShattered = false;

    public Rigidbody rb;


    public bool IsShattered
    {
        get
        {
            return _isShattered;
        }

        set
        {
            _isShattered = value;
            CheckShattered();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.rigidbody != null
            &&
            other.rigidbody.velocity.magnitude >= impactThreshhold)
        {
            IsShattered = true;
        }
    }

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        //rb.detectCollisions = false;
	}
	
    void CheckShattered()
    {
        if (IsShattered == true)
        {
            rb.isKinematic = false;
            //rb.detectCollisions = true;
        }
        else
        {
            rb.isKinematic = true;
            //rb.detectCollisions = false;
        }
    }
}
