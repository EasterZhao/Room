using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    private void LateUpdate()
    {
          // Get the main camera
        Camera mainCamera = Camera.main;

        if (mainCamera != null)
        {
            // Get the camera's forward vector projected onto the XZ plane
            Vector3 cameraForward = mainCamera.transform.forward;
            cameraForward.y = 0f; // Set the Y component to 0 to restrict vertical rotation

            // Rotate the UI element to face the camera horizontally
            transform.LookAt(transform.position + cameraForward, mainCamera.transform.rotation * Vector3.up);
        }
    }
    

}
