using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShardManager : MonoBehaviour
{
    public ShatterScript[] shatterScripts;

    public float defaultImpactThreshhold;
    public float wineImpactThreshhold;
    public float fragileImpactThreshhold;
    public float meshThiccness;

    // Use this for initialization
    void Start ()
    {
        shatterScripts = FindObjectsOfType<ShatterScript>();
        foreach (ShatterScript scripts in shatterScripts)
        {
            //if (scripts.GetComponent<Rigidbody>() == null)
            //{
            //    scripts.gameObject.AddComponent<Rigidbody>();
            //}
            //if (scripts.GetComponent<MeshCollider>() == null)
            //{
            //    scripts.gameObject.AddComponent<MeshCollider>();
            //}
            scripts.impactThreshhold = defaultImpactThreshhold;
            if (scripts.tag == "Wine")
            {
                scripts.impactThreshhold = wineImpactThreshhold;
            }
            if (scripts.tag == "Fragile")
            {
                scripts.impactThreshhold = fragileImpactThreshhold;
            }
            //scripts.GetComponent<MeshCollider>().convex = true;
            //scripts.GetComponent<MeshCollider>().inflateMesh = true;
            scripts.GetComponent<MeshCollider>().skinWidth = meshThiccness;
        }



	}

}
