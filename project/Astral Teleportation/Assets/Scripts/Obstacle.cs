using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private PlayerController player;
    private Rigidbody2D _rigidbody2D;
    private PlayerHealthRed redPlayerHealth;
    private PlayerHealthBlue bluePlayerHealth;
    private Animator animator;
    private AudioSource hitSource;


    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hitSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "RedPlayer")
        {
            animator.SetInteger("AnimState",1);
            player = collision.GetComponent<PlayerController>();
            _rigidbody2D = collision.GetComponent<Rigidbody2D>();
            redPlayerHealth = collision.GetComponent<PlayerHealthRed>();
            redPlayerHealth.health -= 1;
            player.speedModifier = -player.speedModifier;
            hitSource.Play();
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
            animator.SetInteger("AnimState",1);
            player = collision.GetComponent<PlayerController>();
            _rigidbody2D = collision.GetComponent<Rigidbody2D>();
            bluePlayerHealth = collision.GetComponent<PlayerHealthBlue>();
            bluePlayerHealth.health -= 1;
            player.speedModifier = -player.speedModifier;
            hitSource.Play();
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
