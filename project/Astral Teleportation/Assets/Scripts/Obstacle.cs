using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public PlayerController player;
    public Rigidbody2D _rigidbody2D;
    public PlayerHealthRed redPlayerHealth;
    public PlayerHealthBlue bluePLayerHealth;
    public Vector2 knockback = new Vector2();
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "RedPlayer")
        {
            player = collision.GetComponent<PlayerController>();
            _rigidbody2D = collision.GetComponent<Rigidbody2D>();
            redPlayerHealth = collision.GetComponent<PlayerHealthRed>();
            float knockbackMultiplier = player.speedModifier * player.speed;
            
            knockback = new Vector2(knockbackMultiplier * 2, knockbackMultiplier*2);
            _rigidbody2D.AddForce(-knockback);
            redPlayerHealth.health -= 1;

            if(redPlayerHealth.health <= 0)
            {
                player.isDead = true;
            }
            
        }
        if(collision.gameObject.tag == "BluePlayer")
        {
            player = collision.GetComponent<PlayerController>();
            _rigidbody2D = collision.GetComponent<Rigidbody2D>();
            bluePLayerHealth = collision.GetComponent<PlayerHealthBlue>();
            float knockbackMultiplier = player.speedModifier * player.speed;
            
            knockback = new Vector2(knockbackMultiplier * 2, knockbackMultiplier*2);
            _rigidbody2D.AddForce(-knockback);
            bluePLayerHealth.health -= 1;
            
            if(bluePLayerHealth.health <= 0)
            {
                player.isDead = true;
            }
        }
    }
}
