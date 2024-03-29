﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 300f;
    public float speedModifier = 0f;
    public float jumpForce = 150f;
    public bool isRed;
    public bool isBlue;
    public bool isDead = false;
    public bool rooted = false;
    private Rigidbody2D rb2D;
    private SpriteRenderer spriteRenderer;
    private PlayerController player;
    private float speedIncrease = 15f;
    private float stopMultiplier = 2f;
    private float stopPlayer = 15f;

    
    
    void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponent<PlayerController>();
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
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
            if (Input.GetKey("w") && rb2D.velocity.y == 0 && !rooted)
            {
                jump();
            }

        }

        else
        {
            freezePlayerActions();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RedCharacter")
        {
            var otherRB = collision.gameObject.GetComponent<Rigidbody2D>();
            var otherPlayer = 
                collision.gameObject.GetComponent<PlayerController>();
            if(rb2D.position.x < otherRB.position.x)
            {
                Debug.Log("Blue left of Red");
                player.speedModifier = -player.speed;
                otherPlayer.speedModifier = otherPlayer.speed;
            }
            if(rb2D.position.x > otherRB.position.x)
            {
                Debug.Log("Red left of Blue");
                player.speedModifier = player.speed;
                otherPlayer.speedModifier = -otherPlayer.speed;
            }
            if(rb2D.position.x == otherRB.position.x)
            {
                Debug.Log("Red/Blue on Red/Blue");
                player.speedModifier = player.speed;
                otherPlayer.speedModifier = -otherPlayer.speed;
            }
        }
    }

    public void moveLeft()
    {
        spriteRenderer.flipX = true;
        if(!isDead)
        {
            if(speedModifier > -(speed))
            {
                speedModifier -= speedIncrease;
                rb2D.velocity = new Vector2(speedModifier, rb2D.velocity.y);
            }
            if(speedModifier <= -(speed))
            {
                rb2D.velocity = new Vector2(-(speed), rb2D.velocity.y);
            }
        }
    }

    public void moveRight()
    {
        spriteRenderer.flipX = false;
        if(!isDead)
        {
            if(speedModifier < speed)
            {
                speedModifier += speedIncrease;
                rb2D.velocity = new Vector2(speedModifier, rb2D.velocity.y);
            }
            if(speedModifier >= speed)
            {
                rb2D.velocity = new Vector2(speed, rb2D.velocity.y);
            }
        }
    }

    public void jump()
    {
        if(!isDead)
        {
            rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    public void stopMovement()
    {
        if(speedModifier > stopPlayer)
        {
            speedModifier -= speedIncrease * stopMultiplier;
            rb2D.velocity = new Vector2(speedModifier, rb2D.velocity.y);
        }
        else if(speedModifier < -stopPlayer)
        {
            speedModifier += speedIncrease * stopMultiplier;
            rb2D.velocity = new Vector2(speedModifier, rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity = new Vector2(0f, rb2D.velocity.y);
        }
    }

    public void freezePlayerActions()
    {
        if(speedModifier > stopPlayer)
        {
            transform.Rotate(new Vector3(0,0,90));
            speedModifier = 0;
            rb2D.velocity = new Vector2(speedModifier, rb2D.velocity.y);
        }
        else if(speedModifier < -stopPlayer)
        {
            transform.Rotate(new Vector3(0,0,-90));
            speedModifier = 0;
            rb2D.velocity = new Vector2(speedModifier, rb2D.velocity.y);
        }
        else
        {
            speedModifier = 0;
            rb2D.velocity = new Vector2(speedModifier, rb2D.velocity.y);
        }
    }
}
