using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;  // Reference to the player object
    public Vector3 offset;    // Offset from the player's position

    void LateUpdate()
    {
        if (player != null)
        {
            // Set the camera's position to the player's position with the offset
            transform.position = player.position + offset;
        }
    }
}