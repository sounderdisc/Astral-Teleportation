using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveBlue : MonoBehaviour
{
    public PlayerController player;
    public ObjectiveRed otherObjective;
    public bool blueObjective;
    public bool isTaken = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(player.isDead)
        {
            Destroy(gameObject);
            isTaken = false;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isTaken && collision.gameObject.tag == "BluePlayer")
        {
            player = collision.GetComponent<PlayerController>();
            
            Debug.Log("isRed = " + player.isRed + " Got their objective!");
            gameObject.transform.parent = player.gameObject.transform;
            isTaken = true;

            if (otherObjective.isTaken)
            {
                Debug.Log("Both objectives taken, loading next level");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } 
            else
            {
                Debug.Log("one objective taken. will not load level until both are taken");
            }
        }
            
        else
        {
            Debug.Log("player and objective color do not match");
        }
            // uncomment the next line and add a check to make sure both players are at the objective. maybe turn off the player's colision once they reach the objective so they dont get in the way of the other player
            // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
