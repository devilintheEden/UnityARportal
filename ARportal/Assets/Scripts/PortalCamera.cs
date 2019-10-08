using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{

    //public Transform portal;
    private Vector3 begin_pos;
    private Vector3 begin_rot;
    // Update is called once per frame
    public Transform ARcamera;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("plane") != null)
        {
            transform.position = new Vector3(100 - 3 * (ARcamera.position.x-begin_pos.x), 2 + 3 * (ARcamera.position.y-begin_pos.y), -6 + 3 * (ARcamera.position.z-begin_pos.z));
            transform.rotation = Quaternion.Euler(new Vector3(ARcamera.rotation.eulerAngles.x - begin_rot.x, -(ARcamera.rotation.eulerAngles.y - begin_rot.y), 0));
        }
        else
        {
            begin_pos = ARcamera.position;
            begin_rot = ARcamera.rotation.eulerAngles;
        }
    }
}
