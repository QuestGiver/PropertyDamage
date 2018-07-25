using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public bool addPoint = false;

    // Update is called once per frame
    void Update()
    {

        if (addPoint)
        {
            PublicContainer.Score++;
            addPoint = false;
            this.enabled = false;
        }
    }
}
