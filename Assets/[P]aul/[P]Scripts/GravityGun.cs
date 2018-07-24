using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGun : MonoBehaviour
{
    [Tooltip("High number increases the strength of the force")]
    public float trueIntensity;
    public float range;
    public float area;
    public bool push;
    public bool isCasting = false;
    public Camera camera;

    // Use this for initialization
    void Start()
    {

    }

    public void CastGravity()
    {
        RaycastHit hit;
        Physics.Raycast(camera.transform.position, transform.forward, out hit);//, range, 0, QueryTriggerInteraction.Collide);
        GravityWell(hit.point);
    }

    void GravityWell(Vector3 origin)
    {
        foreach (Collider item in Physics.OverlapSphere(transform.position,area))
        {
            //activate rigidbody of item here

            float modifiedIntensity = trueIntensity * (1.0f - (Vector3.Distance(origin, item.transform.position) / area));

            if (item.GetComponent<Rigidbody>() != null && (item.tag != "Player"))
            {
                if (push)
                {
                    item.GetComponent<Rigidbody>().AddForce((origin - item.ClosestPoint(origin)).normalized * modifiedIntensity);
                }
                else
                {
                    item.GetComponent<Rigidbody>().AddForce((origin - item.ClosestPoint(origin)).normalized * -modifiedIntensity);

                }
            }
        }
    }


}
