using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Objective : MonoBehaviour
{
    public PlayerController player;
    public Objective otherObjective;
    public bool isRed;
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
        if (!isTaken && ((isRed && collision.gameObject.tag == "RedPlayer") || (!isRed && collision.gameObject.tag == "BluePlayer")))
        {
            isTaken = true;
            gameObject.transform.parent = player.gameObject.transform;
            Debug.Log(isRed + "got their Objective");

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
    }
}
