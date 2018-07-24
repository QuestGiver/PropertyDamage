using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShardManager : MonoBehaviour
{
    public ShatterScript[] shatterScripts;

    public float impactThreshhold;
    public float meshThiccness;

    // Use this for initialization
    void Start ()
    {
        shatterScripts = FindObjectsOfType<ShatterScript>();
        foreach (ShatterScript scripts in shatterScripts)
        {
            scripts.impactThreshhold = impactThreshhold;
            scripts.GetComponent<MeshCollider>().inflateMesh = true;
            scripts.GetComponent<MeshCollider>().skinWidth = meshThiccness;

        }
	}

}
