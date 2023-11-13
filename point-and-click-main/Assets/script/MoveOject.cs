using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOject : MonoBehaviour
{
    private Camera cam;

    void Update()
    {
        cam = Camera.main;
    }

    private void OnMouseDrag()
    {
        float distantToScreen = cam.WorldToScreenPoint(transform.position).z;

        transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distantToScreen));
    }
}
