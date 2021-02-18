using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5.5f;
    public float speedModifier = 0f;

    public bool isDead = false;
    private float speedIncrease = 0.2f;

    private Rigidbody2D rb2D;
    private float jumpForce = 11.5f;
    public bool rooted = false;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        //rb2D = gameObject.getComponent(typeof(RigidBody2D));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if(!isDead)
        {
            if(Input.GetKey("d") && !Input.GetKey("a") && !rooted)
            {
                if(speedModifier < speed)
                {
                    speedModifier += speedIncrease;
                    pos.x += speedModifier * Time.deltaTime;
                }
                if(speedModifier >= speed)
                {
                    pos.x += speed * Time.deltaTime;
                }
            }

            if(Input.GetKey("a") && !Input.GetKey("d") && !rooted)
            {
                if(speedModifier > -(speed))
                {
                    speedModifier -= speedIncrease;
                    pos.x += speedModifier * Time.deltaTime;
                }
                if(speedModifier <= -(speed))
                {
                    pos.x += -(speed) * Time.deltaTime;
                }
            }
            
            if((!Input.GetKey("a") && !Input.GetKey("d")) || 
                (Input.GetKey("a") && Input.GetKey("d")) || rooted)
            {
                if(speedModifier > 0.2)
                {
                    speedModifier -= speedIncrease * 1.25f;
                    pos.x += speedModifier * Time.deltaTime;
                }
                else if(speedModifier < -0.2)
                {
                    speedModifier += speedIncrease * 1.25f;
                    pos.x += speedModifier * Time.deltaTime;
                }
                else
                {
                    pos.x += 0;
                }

            }

            // so, some things i see i need to do is refactor the above code into functions "moveLeft" and "moveRight" so we can make unit tests
            // also need to configure inputs from project settings so that we can map both wasd and arrow keys to inputs, and that even makes controler support possible later
            // right now, our left and right movement is done by setting our position every frame. it may be better for performance and for player experience if we used forces instead. here's a link to an api page https://docs.unity3d.com/ScriptReference/Rigidbody2D-velocity.html
            // For now, I'll throw jumping functionality in here too, and fix it later this week when i refactor the other things too -Matthew

            if (Input.GetKey("w") && rb2D.velocity.y == 0)
            {
                rb2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            }

            transform.position = pos;
        }

        else
        {
            if(speedModifier > 0.2)
                {
                    transform.Rotate(new Vector3(0,0,90));
                    speedModifier = 0;
                    pos.x += 0;
                }
                else if(speedModifier < -0.2)
                {
                    transform.Rotate(new Vector3(0,0,-90));
                    speedModifier = 0;
                    pos.x += 0;
                }
                else
                {
                    pos.x += 0;
                }
        }
    }
}
