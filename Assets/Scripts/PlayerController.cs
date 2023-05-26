using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector2 movement;
    public float moveSpeed = 1.0f;
    public Animator playerBody,playerHair,playerTop,playerBottom;


    public float x=1f;
    public float xy=-1f;
    
    void Start()
    {

    }



    void Update()
    {

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        playerBody.SetFloat("Horizontal", movement.x);
        playerBody.SetFloat("Vertical", movement.y);

        playerHair.SetFloat("Horizontal", movement.x);
        playerHair.SetFloat("Vertical", movement.y);

        playerTop.SetFloat("Horizontal", movement.x);
        playerTop.SetFloat("Vertical", movement.y);

        playerBottom.SetFloat("Horizontal", movement.x);
        playerBottom.SetFloat("Vertical", movement.y);


        olay();


        playerBody.SetFloat("X", x);
        playerBody.SetFloat("XYValue", xy);

        playerHair.SetFloat("X", x);
        playerHair.SetFloat("XYValue", xy);

        playerTop.SetFloat("X", x);
        playerTop.SetFloat("XYValue", xy);

        playerBottom.SetFloat("X", x);
        playerBottom.SetFloat("XYValue", xy);





    }



    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }




    void olay()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            //yukarý
            x = 1f;
            xy = 1f;
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            //aþaðý
            x = 1f;
            xy = -1f;
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            //sað
            x = -1f;
            xy = 1f;
        }


       else  if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            //sol
            x = -1f;
            xy = -1f;
        }
        

    }
}
