using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 5f;
    public float speedModifier = 0f;

    private float speedIncrease = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if(Input.GetKey("d"))
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

        if(Input.GetKey("a"))
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
        
        if(!Input.GetKey("a") && !Input.GetKey("d"))
        {
            if(speedModifier > 0.5)
            {
                speedModifier -= speedIncrease * 3;
                pos.x += speedModifier * Time.deltaTime;
            }
            else if(speedModifier < -0.5)
            {
                speedModifier += speedIncrease * 3;
                pos.x += speedModifier * Time.deltaTime;
            }
            else
            {
                pos.x += 0;
            }

        }

        transform.position = pos;

    }
}
