using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    private void Update()
    {
        // Get the input axes
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Create a movement vector based on the input axes
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Move the player in the direction the camera is facing
        transform.Translate(Camera.main.transform.TransformDirection(movement) * moveSpeed * Time.deltaTime);
    }
}