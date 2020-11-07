using UnityEngine;

public class FPS_Character : MonoBehaviour
{
    //Variables
    public CharacterController controller;
    public float speed = 12f;

    private void Update()
    {
        //Get Input
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        //Apply movement depending on the input
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }
}
