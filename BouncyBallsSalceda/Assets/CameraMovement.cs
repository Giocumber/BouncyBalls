using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player; // Reference to the player's Transform
    public Vector3 offset;   // Offset position between the player and the camera
    public float smoothTime = 0.125f; // Smoothing speed for the camera movement
    public float fixedZPosition = -10f; // Fixed Z position for the camera in 2D

    private Vector3 velocity = Vector3.zero;

    void Update()
    {
        // Calculate the desired position with the offset, keeping the z position fixed
        Vector3 desiredPosition = new Vector3(player.position.x + offset.x, player.position.y + offset.y, fixedZPosition);

        // Smoothly interpolate between the current position and the desired position
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, desiredPosition, ref velocity, smoothTime);


        // Set the camera's position to the smoothed position
        transform.position = smoothedPosition;
    }
}
