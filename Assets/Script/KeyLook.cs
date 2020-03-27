using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyLook : MonoBehaviour
{

    public float speed = 12f;

    public Transform playerBody;

    public CharacterController controller;

    float xRotation = 0f;
    float yRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float mouseY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        xRotation += mouseX * 2.5f;
       // xRotation = Mathf.Clamp(xRotation, -50f, 50f);

        transform.localRotation = Quaternion.Euler(0f, xRotation, 0f);

        yRotation += mouseY;
        yRotation = Mathf.Clamp(yRotation, -50f, 50f);

        //transform.localRotation = Quaternion.Euler(0f, 0f, yRotation);

        //transform.localRotation = Quaternion.Euler(0f, xRotation, yRotation);

        Vector3 move = transform.forward * 20 * Time.deltaTime + transform.right * mouseX + transform.up * mouseY * 2.5f;

        controller.Move(move * speed * Time.deltaTime);

        

        //  playerBody.Rotate(Vector3.up * mouseY);
        // playerBody.Rotate(Vector3.left * mouseX);
    }
}
