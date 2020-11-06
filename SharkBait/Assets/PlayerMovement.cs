using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //private Vector3 startPos = null;
    //private Vector3 startForce = new Vector3(0,0,0); 
    private Vector2 swimUpForce = new Vector2(0f,50f);
    //private bool isJumping;

    //private bool jumpKeyHeld = false;
    //private Vector2 counterJumpForce = new Vector2(0f,-14f);
    private Vector2 airLeft = new Vector2(-50f, 0f);
    private Vector2 airRight = new Vector2(50f, 0f);
    private float speed = 6f;

    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();
        
        }
    

    // Update is called once per frame
    void Update(){
        if (gameObject.transform.position.y <= 0f){
            if (rb2d != null){
                Destroy(rb2d);
                rb2d = null;
                }
            //player.isKinematic = false;
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxisRaw("Vertical");

            //update the position
            transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput * speed * Time.deltaTime, 0);
        }
        
            //update the position
    }


    void FixedUpdate(){
        if (gameObject.transform.position.y > 0f){
            if(rb2d == null){
                rb2d = gameObject.AddComponent<Rigidbody2D>();
                rb2d.AddForce(speed * swimUpForce);
                   
            }
        }

        // if(Input.GetKeyDown(KeyCode.A)){
        //             rb2d.AddForce(speed * airLeft);
        // }
        
        // if(Input.GetKeyDown(KeyCode.D)){
        //             rb2d.AddForce(speed * airRight);
        // }

            
        // if(Input.GetKeyDown(KeyCode.Space)){
        //     rb2d.AddForce(speed * swimUpForce);
        // }

        // if(isJumping){

        //      if(!jumpKeyHeld && Vector2.Dot(rb2d.velocity, Vector2.up) > 0){

        //      rb2d.AddForce(counterJumpForce * rb2d.mass);
        //      }
        //  }
        //  else if(Input.GetButtonUp("Jump")){
        //      jumpKeyHeld = false;
        //      }
        
    }

    private void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Hit Detected!");
        GameState.Instance.IncreaseScore(10);
        Destroy(other.gameObject);
    }

}
    
