using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            transform.position += transform.forward;
        }
        if (Input.GetKey(KeyCode.S)) {
            transform.position -= transform.forward;
        }

        if (Input.GetKey(KeyCode.A)) {
            transform.position -= transform.right;
        }
        if (Input.GetKey(KeyCode.D)) {
            transform.position += transform.right;
        }

        transform.eulerAngles += new Vector3(Input.GetAxisRaw("Mouse Y"), Input.GetAxisRaw("Mouse X"), 0);


    }
}
