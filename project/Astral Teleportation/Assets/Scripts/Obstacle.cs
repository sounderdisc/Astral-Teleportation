using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public Player player;
    public Rigidbody2D _rigidbody2D;
    public float knockback;
    
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
        if(collision.gameObject.tag == "Player")
        {
            player = collision.GetComponent<Player>();
            _rigidbody2D = collision.GetComponent<Rigidbody2D>();
            _rigidbody2D.AddForce(transform.right * 100); // what if the player contacts the obstacle from the left? then it should knock back in that direction
            player.isDead = true;
            
        }
    }
}
