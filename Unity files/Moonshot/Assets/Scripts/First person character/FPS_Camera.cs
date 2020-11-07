using UnityEngine;

public class FPS_Camera : MonoBehaviour
{
    //Variables
    float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;

    private void Start()
    {
        //Locks the cursor in the center of the screen and hides it.
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        //Get Input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //Apply rotation based on the input
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
