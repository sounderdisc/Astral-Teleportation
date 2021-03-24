using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RedPortalGun : MonoBehaviour
{
    public float fireRate = 0f;
    public LayerMask validTargets;
    public GameObject redPortalPrefab;
    public GameObject bluePortalPrefab;
    public GameObject currentRedPortal;
    public GameObject currentBluePortal;
    public AudioSource portalShootSound;
    public bool debugPortalMode;

    float timeToFire = 0f;
    Transform firepoint;

    public bool onCooldown = false;
    public float timeOnCooldown = 0;

    // Start is called before the first frame update
    void Start()
    {
        portalShootSound = GetComponent<AudioSource>();
        firepoint = transform.Find("FirePoint");
        if(firepoint == null){
            Debug.Log (" no firepoint found!!");
        }
        currentRedPortal = GameObject.Find("RedPortal");
        currentBluePortal = GameObject.Find("BluePortal");
        validTargets = LayerMask.GetMask("Foreground");
        // uncomment next line to revert to old fire mode
        // debugPortalMode = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (fireRate == 0 ){
            if( Input.GetButtonDown ("Fire1")){
                ShootRed();
            }
        }
        else {
            if( Input.GetButton("Fire1") && Time.time > timeToFire){
                timeToFire = Time.time + 1/fireRate;
                ShootRed();
            }
        }

        if (fireRate == 0)
        {
            if (Input.GetButtonDown("Fire2"))
            {
                ShootBlue();
            }
        }
        else
        {
            if (Input.GetButton("Fire2") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                ShootBlue();
            }
        }
        */

        // well, this fixes out double portal shooting problem at least
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
            if (Input.GetButtonDown("Fire1"))
            {
                ShootRed();
            }
            if (Input.GetButtonDown("Fire2"))
            {
                ShootBlue();
            }
        }
        // Debug.DrawLine(this.transform.position, this.transform.position + this.transform.right * 200, Color.green, 2);
        //Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector2 direction = (Vector2)((worldMousePos - firepoint.position));
        //direction.Normalize();
        //Debug.DrawRay(this.transform.position, direction * 200, Color.green, 10);
    }

    void ShootRed() {
        // having trouble with portals shooting while paused. here's a temporty fix
        if (!PauseMenu.isPaused)
        {
            // leaving the old fire mode in for debug purposes, and in case we want to go back and forth
            if (debugPortalMode)
            {
                SpawnRedAtCursorLocation();
                portalShootSound.Play();
            }
            else
            {
                Debug.Log("New Fire Mode! Red");
                SpawnRedUsingRaycast();
            }
        }
    }

    void SpawnRedUsingRaycast()
    {
        // find fire direction for the shot
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (Vector2)((worldMousePos - this.transform.position));
        direction.Normalize();
        Debug.DrawRay(this.transform.position, direction * 200, Color.red, 10);
        // do raycast, get location of hit
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, direction, float.PositiveInfinity, validTargets);
        if (hit.collider == null)
        {
            return;
        }
        Debug.Log("red raycast hit & location: " + hit.collider.name + " @ " + hit.point);
        // Vector3 spawnLocation = hit.collider.gameObject.transform.position;
        Vector2 spawnLocation = hit.point;
        // spawnLocation.z = 662.0625f;
        GameObject newPortal = Instantiate(redPortalPrefab, spawnLocation, Quaternion.identity);
        // now lets fix our references so the portals are connected and actually move players
        // first, let's see if the other color's gun has fired since the Start() function
        currentBluePortal = GameObject.Find("BluePortal(Clone)");
        if (currentBluePortal != null)
        {
            PortalCollision blueScript = currentBluePortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            PortalCollision redScript = newPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            redScript.otherPortal = blueScript;
            blueScript.otherPortal = redScript;
        }
        if (currentRedPortal != null)
        {
            Destroy(currentRedPortal);
        }
        currentRedPortal = newPortal;
    }

    void SpawnRedAtCursorLocation()
    {
        Vector3 spawnLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnLocation.z = 662.0625f;
        GameObject newPortal = Instantiate(redPortalPrefab, spawnLocation, Quaternion.identity);

        // four possible states: no current red and no current blue portal, yes red but no blue, no red but yes blue, and both colors already exist
        if (currentRedPortal == null && currentBluePortal == null)
        {
            currentRedPortal = newPortal;
        }
        else if (currentRedPortal != null && currentBluePortal == null)
        {
            Destroy(currentRedPortal);
            currentRedPortal = newPortal;
        }
        else if (currentRedPortal == null && currentBluePortal != null)
        {
            PortalCollision newRedPortalScript = newPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            PortalCollision bluePortalScript = currentBluePortal.GetComponent(typeof(PortalCollision)) as PortalCollision;

            newRedPortalScript.otherPortal = bluePortalScript;
            bluePortalScript.otherPortal = newRedPortalScript;

            currentRedPortal = newPortal;
        }
        else if (currentRedPortal != null && currentBluePortal != null)
        {
            PortalCollision newRedPortalScript = newPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            PortalCollision bluePortalScript = currentBluePortal.GetComponent(typeof(PortalCollision)) as PortalCollision;

            newRedPortalScript.otherPortal = bluePortalScript;
            bluePortalScript.otherPortal = newRedPortalScript;

            Destroy(currentRedPortal);
            currentRedPortal = newPortal;
        }
    }

    void ShootBlue() {
        // having trouble with portals shooting while paused. here's a temporty fix
        if (!PauseMenu.isPaused)
        {
            // leaving the old fire mode in for debug purposes, and in case we want to go back and forth
            if (debugPortalMode)
            {
                SpawnBlueAtCursorLocation();
                portalShootSound.Play();
            }
            else
            {
                // This functionality is being moved to it's own file because i need to attach a script to the blue arm so the raycast starts from the correct spot.
                // ideally I'll come back later and clean up this 269 line mess of code, but for now, i dont want to break things
                Debug.Log("New Fire Mode! Blue");
            }
        }
    }

    void SpawnBlueAtCursorLocation()
    {
        Vector3 spawnLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnLocation.z = 662.0625f;
        GameObject newPortal = Instantiate(bluePortalPrefab, spawnLocation, Quaternion.identity);

        // four possible states: no current red and no current blue portal, no red but yes blue, yes red but no blue, and both colors already exist
        if (currentRedPortal == null && currentBluePortal == null)
        {
            currentBluePortal = newPortal;
        }
        else if (currentRedPortal == null && currentBluePortal != null)
        {
            Destroy(currentBluePortal);
            currentBluePortal = newPortal;
        }
        else if (currentRedPortal != null && currentBluePortal == null)
        {
            PortalCollision newBluePortalScript = newPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            PortalCollision redPortalScript = currentRedPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;

            newBluePortalScript.otherPortal = redPortalScript;
            redPortalScript.otherPortal = newBluePortalScript;

            currentBluePortal = newPortal;
        }
        else if (currentRedPortal != null && currentBluePortal != null)
        {
            PortalCollision newBluePortalScript = newPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            PortalCollision redPortalScript = currentRedPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;

            newBluePortalScript.otherPortal = redPortalScript;
            redPortalScript.otherPortal = newBluePortalScript;

            Destroy(currentBluePortal);
            currentBluePortal = newPortal;
        }
    }
}

