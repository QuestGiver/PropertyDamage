using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float viewRange = 30;
    public GameObject player;
    private float yTotal;
    void Update()
    {


        float y = Input.GetAxis("Mouse Y") * Time.deltaTime * 90f;
        float x = Input.GetAxis("Mouse X") * Time.deltaTime * 90f;
        yTotal += y;

        if(yTotal <viewRange && yTotal > -viewRange)
        {
            transform.Rotate(-y, 0, 0);
        }
        if(yTotal > viewRange)
        {
            yTotal = viewRange;
        }
        if (yTotal < -viewRange)
        {
            yTotal = -viewRange;
        }
        player.transform.Rotate(0, x, 0);
        //Vector3 cRot = transform.localEulerAngles;

        //float ix = Input.GetAxis("Mouse X");
        //if (ix != 0)
        //{
        //    float deltax = viewRange * ix;

        //    if (deltax < 0f)
        //        cRot.x = 360 + deltax;
        //    else
        //        cRot.x = deltax;
        //    Debug.Log(cRot.x);

        //    transform.localEulerAngles = cRot;
        //}





        //if (yTotal > viewRange && yTotal < -viewRange)
        //{

        //}
        //else
        //{
        //    transform.Rotate(-y, 0, 0);

        //    player.transform.Rotate(0, x, 0);
        //}



    }
}
//Vector3 targetRotation = transform.localRotation.eulerAngles;

//Vector3 rotY = (Vector3.left * Input.GetAxis("Mouse Y") * 3.5f);

//targetRotation = rotY;


////targetRotation.x = Mathf.Clamp(targetRotation.x, -30, 30);


//Debug.Log(targetRotation.x);



//if (targetRotation.x < viewRange)
//{
//    targetRotation += rotY;
//    if (targetRotation.x == 0)
//    {
//        targetRotation.x = -1;
//    }
//}
//else
//{
//    targetRotation.x = -viewRange;
//}



//if (targetRotation.x > -viewRange)
//{
//    targetRotation += rotY;
//    if (targetRotation.x == 0)
//    {
//        targetRotation.x = 1;
//    }
//}
//else
//{
//    targetRotation.x = viewRange;
//}


//transform.rotation = Quaternion.Euler(targetRotation);