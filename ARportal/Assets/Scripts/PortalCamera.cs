using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{

    //public Transform portal;

    // Update is called once per frame
    public Transform ARcamera;
    // Update is called once per frame
    void Update()
    {
            transform.position = new Vector3(100 - 3 * ARcamera.position.x, (float)0.3 +3 * ARcamera.position.y, (float)-1.8+ 3 * ARcamera.position.z);
            transform.rotation = Quaternion.Euler(new Vector3(ARcamera.rotation.eulerAngles.x, -ARcamera.rotation.eulerAngles.y, -ARcamera.rotation.eulerAngles.z) );
    }
}
