using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    private GameObject playerObj = null;
    private bool isJumping;
    private bool jumpKeyHeld;
    private Vector2 counterJumpForce = new Vector2(0f, -20f) ;
    private float jumpForce = 3f;
    private float movementSpeed = 6f;

    private Rigidbody2D player;

    // Start is called before the first frame update
    void Start(){
        player = GetComponent<Rigidbody2D>();
        player.mass = 0;
        if (playerObj == null){
            playerObj = FindObjectOfType<PlayerMovement>().gameObject;
        }
    }

    // Update is called once per frame
    void Update(){
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        
        if(playerObj.transform.position.y < -.2f){
            

            //update the position
            transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);
        }

        if(Input.GetButtonDown("Jump") && playerObj.transform.position.y >= -.2f){
            jumpKeyHeld = true;
            if(jumpKeyHeld == true){
                
                isJumping = true;
                player.AddForce(Vector2.up * jumpForce * player.mass, ForceMode2D.Impulse);
            }
    
        }
        else if(Input.GetButtonUp("Jump")){
        //not high enough
        jumpKeyHeld = false;
        }

    }

    void FixedUpdate(){
        if(isJumping){

            if(!jumpKeyHeld && Vector2.Dot(player.velocity, Vector2.up) > 0){

            player.AddForce(counterJumpForce);
            }
        }
        else if(Input.GetButtonUp("Jump")){
            jumpKeyHeld = false;
            }
        
        if (playerObj.transform.position.y < -.2f){
            player.mass = 0;
        }
        else;
            player.mass = 1f;
    }

    private void OnTriggerEnter2D(Collider2D other){
        Destroy(other.gameObject);
    }

}
    
