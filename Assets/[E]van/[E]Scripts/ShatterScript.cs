using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterScript : MonoBehaviour
{
    public float impactThreshhold;

    private bool _isShattered = false;

    public Rigidbody rb;

    public AddPoints add;


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

    void Start ()
    {

        rb = GetComponent<Rigidbody>();
        rb.isKinematic = true;
        add = GetComponent<AddPoints>();
	}

    void CheckShattered()
    {
        if (IsShattered == true)
        {
            add.addPoint = true;
            rb.isKinematic = false;
            StartCoroutine(StopMoving());
        }
        else
        {
            rb.isKinematic = true;
        }
    }

    IEnumerator StopMoving()
    {
        yield return new WaitForSeconds(0.1f);
        if (rb.velocity.magnitude <= 0.5f)
        {
            rb.isKinematic = true;
            rb.detectCollisions = false;
        }
    }
}
