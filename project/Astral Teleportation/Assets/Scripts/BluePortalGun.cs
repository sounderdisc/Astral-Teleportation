using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;

public class BluePortalGun : MonoBehaviour
{
    public LayerMask validTargets;
    public GameObject bluePortalPrefab;
    public GameObject currentRedPortal;
    public GameObject currentBluePortal;
    public AudioSource portalShootSound;
    public bool debugPortalMode;

    public bool onCooldown = false;
    public float timeOnCooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        portalShootSound = GetComponent<AudioSource>();
        currentRedPortal = GameObject.Find("RedPortal");
        currentBluePortal = GameObject.Find("BluePortal");
        validTargets = LayerMask.GetMask("Foreground");
        // uncomment next line to revert to old fire mode
        // debugPortalMode = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (onCooldown)
        {
            timeOnCooldown += 1 * Time.deltaTime;
            if (timeOnCooldown >= 0.1)
            {
                onCooldown = false;
                timeOnCooldown = 0;
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire2"))
            {
                ShootBlue();
            }
        }
    }

    void ShootBlue()
    {
        // dont shoot if paused
        if (!PauseMenu.isPaused)
        {
            // leaving the old fire mode in for debug purposes, and in case we want to go back and forth
            if (debugPortalMode)
            {
                Debug.Log("debugPortalMode is true, so BluePortalGun doesn't do anything");
            }
            else
            {
                // try catch is jank, but we're out of time. this will make level 6 blue portal gun not make sound, but let the gun fire otherwise
                try
                {
                    portalShootSound.Play();
                }
                catch(Exception e)
                {
                    Debug.Log(e);
                }
                SpawnBlueUsingRaycast();
            }
        }
    }

    void SpawnBlueUsingRaycast()
    {
        // find fire direction for the shot
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (Vector2)((worldMousePos - this.transform.position));
        direction.Normalize();

        Debug.DrawRay(this.transform.position, direction * 200, Color.blue, 10);

        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, direction, float.PositiveInfinity, validTargets);

        Quaternion hitObjectRotation = Quaternion.LookRotation(hit.normal);

        if (hit.collider == null)
        {
            return;
        }
        Debug.Log("blue raycast hit & location: " + hit.collider.name + " @ " + hit.point);
        Vector2 spawnLocation = hit.point;
        GameObject newPortal = Instantiate(bluePortalPrefab, spawnLocation, Quaternion.identity);

        // now lets fix our references so the portals are connected and actually move players
        // first, let's see if the other color's gun has fired since the Start() function
        if (currentRedPortal == null)
            currentRedPortal = GameObject.Find("RedPortal(Clone)");
        if (currentRedPortal != null)
        {
            PortalCollision redScript = currentRedPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            PortalCollision blueScript = newPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            blueScript.otherPortal = redScript;
            redScript.otherPortal = blueScript;
        }
        if (currentBluePortal != null)
        {
            Destroy(currentBluePortal);
        }
        currentBluePortal = newPortal;
        // rotation of new portal happens here
        Debug.Log("Quaternion: x:" + hitObjectRotation[0] + "y:" + hitObjectRotation[1]);
        if (hitObjectRotation[0] < 0)
        {
            Debug.Log("rotating");
            newPortal.transform.Rotate(Vector3.back);
        }
        newPortal.transform.rotation = hitObjectRotation;
        if (hitObjectRotation[0] != 0)
        {
            newPortal.transform.Rotate(new Vector3(90, 90, 0));
        }
        if (hitObjectRotation[1] != 0)
        {
            newPortal.transform.Rotate(new Vector3(0, 90, 0));
        }
    }
}

