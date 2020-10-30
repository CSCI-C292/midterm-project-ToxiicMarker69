using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    private Vector3 startPos = transform.position;
    private Vector3 startForce = new Vector3(0,0,0); 
    private Vector3 swimUpForce = new Vector3(0f,2f,0f);
    private bool isJumping;

    private float speed = 6f;

    private Rigidbody2D player;

    // Start is called before the first frame update
    void Start(){
        player = GetComponent<Rigidbody2D>();
        
        }
    

    // Update is called once per frame
    void Update(){
        
        

            //update the position
    }


    void FixedUpdate(){

        if(Input.GetKeyDown(KeyCode.Space)){
            player.AddForce(transform.up * swimUpForce);
        }

        // if(isJumping){

        //     if(!jumpKeyHeld && Vector2.Dot(player.velocity, Vector2.up) > 0){

        //     player.AddForce(counterJumpForce*player.mass);
        //     }
        // }
        // else if(Input.GetButtonUp("Jump")){
        //     jumpKeyHeld = false;
        //     }
        
        // if (playerObj.transform.position.y < -.2f){
        //     player.mass = 0;
        // }
        // else;
        //     player.mass = 1f;
    }

    private void OnTriggerEnter2D(Collider2D other){
        Destroy(other.gameObject);
    }

}
    
