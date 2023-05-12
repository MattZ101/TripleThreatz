using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 5f;

    private float mouseX, mouseY;
    private float rotationX = 0f;
    private float rotationY = 0f;

    void Update()
    {
        // Get the mouse input for rotation
        mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

        // Rotate the camera based on mouse movement
        rotationX -= mouseY;
        rotationY += mouseX;

        // Clamp the vertical rotation to avoid flipping the camera
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        // Apply the rotation to the camera
        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }
}