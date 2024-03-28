using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public AudioSource footstepsSound, sprintSound;

    public float speed = 12f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    public float runSpeed = 24f;
    public float maxStamina = 100f;
    public float Stamina = 100f;


    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public Text StaminaText;

    Vector3 velocity;
    bool isGrounded;

    void Update()
    {
        StaminaText.text = Stamina.ToString();
        if (Input.GetKey(KeyCode.LeftShift))
            {
                if(Stamina!=0)
                    Stamina--;
            }
        else{
                if(Stamina!=maxStamina)
                    Stamina++;
            }    
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)){
            if (Input.GetKey(KeyCode.LeftShift) && Stamina>0)
            {
                footstepsSound.enabled = false;
                sprintSound.enabled = true;
            }
            else
            {
                footstepsSound.enabled = true;
                sprintSound.enabled = false;
            }
        }
        else
        {
            footstepsSound.enabled = false;
            sprintSound.enabled = false;
        }

        Vector3 move = transform.right * x +transform.forward *z;
        if (Input.GetKey(KeyCode.LeftShift) && Stamina>0)
            {
                controller.Move(move * runSpeed * Time.deltaTime);
            }
        else
            {
                controller.Move(move * speed * Time.deltaTime);
            }
            
        
        if(Input.GetButtonDown("Jump")&& isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
