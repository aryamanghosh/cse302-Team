using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class draganddrop : MonoBehaviour
{
    private Camera playerCam;
    private Vector3 mousePosition;

    private void Start()
    {
        // Assuming your camera is a child of the CameraHolder GameObject
        GameObject cameraHolder = GameObject.Find("CameraHolder");

        if (cameraHolder != null)
        {
            playerCam = cameraHolder.GetComponentInChildren<Camera>();
        }
        else
        {
            Debug.LogError("CameraHolder not found.");
        }
    }

    private Vector3 GetMousePos()
    {
        return playerCam.WorldToScreenPoint(transform.position);
    }

    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();
    }

    private void OnMouseDrag()
    {
        transform.position = playerCam.ScreenToWorldPoint(Input.mousePosition - mousePosition);
    }
}
