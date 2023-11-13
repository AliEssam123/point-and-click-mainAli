using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float sensitivity = 100f;

    private void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;

        // Rotate around the object's local Y-axis and global X-axis
        transform.Rotate(Vector3.up, -XaxisRotation, Space.World);
    }
}