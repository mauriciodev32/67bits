using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    public float speed = 5f;
    public Joystick joystick;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();   
    }

    void Update()
    {
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        //Debug.Log("Input detectado: " + movHorizontal + ", " + movVertical);

        Vector3 move = new Vector3(movHorizontal, 0, movVertical);
        controller.Move(move * speed * Time.deltaTime);

        Vector3 direction = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        transform.Translate(direction * speed * Time.deltaTime);
    }

}
