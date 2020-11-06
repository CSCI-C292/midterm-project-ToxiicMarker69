using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float movementSpeed = 6f;   
    void Update()
        {
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxisRaw("Vertical");

            //update the position
            transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);

            //output to log the position change
            Debug.Log(transform.position);
        }
}
