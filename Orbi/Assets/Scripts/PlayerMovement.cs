using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    //PlayerMovement

    //sets all the movement off

    private float xMove;    

    bool isJumping;
    Rigidbody rb;

    public Animator JumpAnim;


    void Awake()
    {
        isJumping = true;
    }

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }
    
    //moves the player
    void Update()
    {
        xMove = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3((xMove * 12.5f * Time.deltaTime), 0.0f, 0.0f));

        Jump();
        WallJump();
    }


    //jump script with animation
    void Jump()
    {
        if (Input.GetKeyDown("space") && isJumping == true || (Input.GetKeyDown("w") && isJumping == true))
        {
            isJumping = false;

            StartCoroutine(SquashJump());
                       
            rb.AddForce(new Vector3(0, 20f, 0), ForceMode.Impulse);
        }

    }

    void WallJump()
    {
        if (Input.GetKeyDown("space") && isJumping == true || (Input.GetKeyDown("w") && isJumping == true))
        {
            isJumping = false;
            rb.AddForce(new Vector3(0, 20f, 0), ForceMode.Impulse);
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isJumping = true;
            
        }
    }  

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("WallJumpFixed"))
        {
            isJumping = true;
        }
    }


    //animation
    IEnumerator SquashJump()
    {
        JumpAnim.SetBool("Jump", true);
        JumpAnim.Play("PlayerJump");
        yield return new WaitForSeconds(0.5f);
        JumpAnim.SetBool("Jump", false);
    }
}