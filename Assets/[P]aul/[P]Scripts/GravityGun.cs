using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityGun : MonoBehaviour
{
    [Tooltip("High number increases the strength of the force")]
    public float trueIntensity;
    public float range;
    public float area;
    public bool pull;
    public float projectionOriginDist = 5;
    public bool isCasting = false;

    // Use this for initialization
    void Start()
    {

    }
    RaycastHit hit;
    public void CastGravity()
    {

        if (Physics.Raycast(Camera.main.transform.position + (Camera.main.transform.forward * projectionOriginDist), Camera.main.transform.forward, out hit,range))
        {
            GravityWell(hit.point);
        }//, range, 0, QueryTriggerInteraction.Collide);
        else
        {
            GravityWell(Camera.main.transform.forward * range);
        }

    }

    void GravityWell(Vector3 origin)
    {
        foreach (Collider item in Physics.OverlapSphere(transform.position,area))
        {
            //activate rigidbody of item here

            //float modifiedIntensity = trueIntensity;// * (1.0f - (Vector3.Distance(origin, item.transform.position) / area));

            if (item.GetComponent<Rigidbody>() != null && (item.tag != "Player"))
            {
                if (pull)
                {
                    item.GetComponent<Rigidbody>().AddForce((origin - item.ClosestPoint(origin)).normalized * trueIntensity);
                }
                else
                {
                    item.GetComponent<Rigidbody>().AddForce((origin - item.ClosestPoint(origin)).normalized * -trueIntensity);

                }
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Camera.main.transform.position + (Camera.main.transform.forward * projectionOriginDist), hit.point);
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Camera.main.transform.position + (Camera.main.transform.forward * projectionOriginDist), Camera.main.transform.forward * range);
        Gizmos.DrawWireSphere(hit.point, area);

    }


}
