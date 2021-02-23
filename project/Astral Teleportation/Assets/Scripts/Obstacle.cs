using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public PlayerController player;
    public Rigidbody2D _rigidbody2D;
    public PlayerHealthRed redPlayerHealth;
    public PlayerHealthBlue bluePlayerHealth;

    
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
            redPlayerHealth.health -= 1;
            player.speedModifier = -player.speedModifier;
            if(player.speedModifier < 0.2 || player.speedModifier > 0.2)
            {
                _rigidbody2D.AddForce(transform.up * player.speedModifier/2, ForceMode2D.Impulse);
            }
            else
            {
                _rigidbody2D.AddForce(transform.up * player.speed, ForceMode2D.Impulse);
            }
        }
        if(collision.gameObject.tag == "BluePlayer")
        {
            player = collision.GetComponent<PlayerController>();
            _rigidbody2D = collision.GetComponent<Rigidbody2D>();
            bluePlayerHealth = collision.GetComponent<PlayerHealthBlue>();
            bluePlayerHealth.health -= 1;
            player.speedModifier = -player.speedModifier;
            if(player.speedModifier < 0.2 || player.speedModifier > 0.2)
            {
                _rigidbody2D.AddForce(transform.up * player.speedModifier/2, ForceMode2D.Impulse);
            }
            else
            {
                _rigidbody2D.AddForce(transform.up * player.speed, ForceMode2D.Impulse);
            }
        }
    }
}
