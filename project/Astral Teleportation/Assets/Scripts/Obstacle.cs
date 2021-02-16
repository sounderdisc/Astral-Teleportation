using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public Player player;
    // Start is called before the first frame update
    void Start()
    {
        // GameObject gameObj = GameObject.FindWithTag("Player");
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
            player.isDead = true;
        }
    }
}
