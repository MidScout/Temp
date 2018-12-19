using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carmine : MonoBehaviour
{


    //public float sensitivityX = 10f;
    //public float sensitivityY = 10f;

    public float sensitivityMouse = 2f;

    void Update()
   {
    //    //鼠标右键实现视角转动，类似第一人称视角
    //    if (Input.GetMouseButton(1))
    //    {
    //        float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
    //        float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
    //        transform.Rotate(-rotationY, rotationX, 0);
    //    }
        if (Input.GetMouseButton(1))
        {
            transform.Rotate(0, Input.GetAxis("Mouse X"),0);
        }
    }


}
