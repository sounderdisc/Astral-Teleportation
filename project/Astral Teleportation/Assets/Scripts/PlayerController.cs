using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5.5f;
    public float speedModifier = 0f;
    public bool isDead = false;
    public bool rooted = false;
    private Rigidbody2D rigidBody2D;
    private float jumpForce = 5f;
    private float speedIncrease = 0.2f;

    
    
    void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!isDead)
        {
            if(Input.GetKey("d") && !Input.GetKey("a") && !rooted)
            {
                moveRight();
            }

            if(Input.GetKey("a") && !Input.GetKey("d") && !rooted)
            {
                moveLeft();
            }
            
            if((!Input.GetKey("a") && !Input.GetKey("d")) || 
                (Input.GetKey("a") && Input.GetKey("d")) || 
                rooted)
            {
                stopMovement();
            }
            if (Input.GetKey("w") && rigidBody2D.velocity.y == 0)
            {
                jump();
            }

        }

        else
        {
            freezePlayerActions();
        }
    }

    public void moveLeft()
    {
        if(speedModifier > -(speed))
        {
            speedModifier -= speedIncrease;
            rigidBody2D.velocity = new Vector2(speedModifier, rigidBody2D.velocity.y);
        }
        if(speedModifier <= -(speed))
        {
            rigidBody2D.velocity = new Vector2(-(speed), rigidBody2D.velocity.y);
        }
    }

    void moveRight()
    {
        if(speedModifier < speed)
        {
            speedModifier += speedIncrease;
            rigidBody2D.velocity = new Vector2(speedModifier, rigidBody2D.velocity.y);
        }
        if(speedModifier >= speed)
        {
            rigidBody2D.velocity = new Vector2(speed, rigidBody2D.velocity.y);
        }
    }

    void jump()
    {
        rigidBody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    void stopMovement()
    {
        if(speedModifier > 0.2)
        {
            speedModifier -= speedIncrease * 1.25f;
            rigidBody2D.velocity = new Vector2(speedModifier, rigidBody2D.velocity.y);
        }
        else if(speedModifier < -0.2)
        {
            speedModifier += speedIncrease * 1.25f;
            rigidBody2D.velocity = new Vector2(speedModifier, rigidBody2D.velocity.y);
        }
        else
        {
            rigidBody2D.velocity = new Vector2(0f, rigidBody2D.velocity.y);
        }
    }

    void freezePlayerActions()
    {
        if(speedModifier > 0.2)
        {
            transform.Rotate(new Vector3(0,0,90));
            speedModifier = 0;
            rigidBody2D.velocity = new Vector2(speedModifier, rigidBody2D.velocity.y);
        }
        else if(speedModifier < -0.2)
        {
            transform.Rotate(new Vector3(0,0,-90));
            speedModifier = 0;
            rigidBody2D.velocity = new Vector2(speedModifier, rigidBody2D.velocity.y);
        }
        else
        {
            rigidBody2D.velocity = new Vector2(speedModifier, rigidBody2D.velocity.y);
        }
    }
}
