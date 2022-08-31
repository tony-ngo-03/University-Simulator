using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody2D rb;
    public bool isWalking;
    public bool facingDown;
    public bool facingUp;
    public bool facingSide;
    public bool flip;

    public bool isSiting;

    private SpriteRenderer spriteRenderer;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        if (Input.GetKeyDown(KeyCode.E) && isSiting)
        {
            speed = 0.65f;
            isSiting = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && !isSiting)
        {
            isSiting = true;
            speed = 0f;
        }


        if(horizontal == 0 && vertical == 0)
        {
            isWalking = false;
            rb.velocity = new Vector2(0, 0);
        }
        else
        {
            isWalking = true;
            //anim.SetBool("isWalking", true);
            // left
            if(horizontal < 0)
            {
                facingSide = true;
                facingUp = false;
                facingDown = false;
                flip = true;
               // anim.SetBool("FacingSide", true);

            }
            // right
            if(horizontal > 0)
            {
                facingSide = true;
                facingDown = false;
                facingUp = false;
                flip = false;
              //  anim.SetBool("FacingSide", true);
            }
            // up
            if(vertical > 0)
            {
                facingUp = true;
                facingSide = false;
                facingDown = false;
               // anim.SetBool("FacingUp", true);
            }
            // down
            if(vertical < 0)
            {
                facingDown = true;
                facingUp = false;
                facingSide = false;
              //  anim.SetBool("FacingDown", true);
            }
            rb.velocity = new Vector2(horizontal * speed, vertical * speed);
        }
    }

    private void resetAll()
    {
        
        isWalking = false;
      //  anim.SetBool("FacingDown", false);
        //anim.SetBool("FacingUp", false);
//anim.SetBool("FacingSide", false);
      //  anim.SetBool("isWalking", false);
    }



    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Door")
        {
            EnterBuildingScript doorScript = collision.gameObject.GetComponent<EnterBuildingScript>();
            doorScript.inRange = true;
        }
    }


    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            EnterBuildingScript doorScript = collision.gameObject.GetComponent<EnterBuildingScript>();
            doorScript.inRange = false;
        }
    }

}
