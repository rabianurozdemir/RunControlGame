using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target; // The target that the camera will follow
    public Vector3 offset; // The offset from the target

    void Start()
    {
        offset = transform.position - target.position; // Calculate the offset

    }

    void LateUpdate() // LateUpdate is called after all Update functions have been called
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, 0.125f); // Move the camera to the target position with a smooth transition
                                                                                                 // Lerp() wants a start position, end position and a float value between 0 and 1

    }
}
