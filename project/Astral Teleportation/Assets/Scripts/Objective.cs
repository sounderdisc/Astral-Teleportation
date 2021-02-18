using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objective : MonoBehaviour
{
    public Player player;

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
        if (collision.gameObject.tag == "Player")
        {
            player = collision.GetComponent<Player>();
            player.rooted = true;
            Debug.Log("Level Complete!");
            // uncomment the next line and add a check to make sure both players are at the objective. maybe turn off the player's colision once they reach the objective so they dont get in the way of the other player
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
