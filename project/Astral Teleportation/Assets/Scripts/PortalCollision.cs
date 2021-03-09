using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PortalCollision : MonoBehaviour
{
    public PortalCollision otherPortal;
    public bool onCooldown = false;
    public float timeOnCooldown = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.tag == "RedPlayer" || collision.gameObject.tag == "BluePlayer") && !onCooldown)
        {
            Debug.Log(collision.gameObject.tag + " has collided with " + gameObject.tag);
            otherPortal.onCooldown = true;
            collision.gameObject.transform.position = otherPortal.gameObject.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (onCooldown)
        {
            timeOnCooldown += 1 * Time.deltaTime;
            if (timeOnCooldown >= 0.5)
            {
                onCooldown = false;
                timeOnCooldown = 0;
            }
        }
    }
}
