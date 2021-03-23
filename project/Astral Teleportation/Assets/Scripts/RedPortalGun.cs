using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class RedPortalGun : MonoBehaviour
{
    public float fireRate = 0f;
    public LayerMask notToHit;
    public GameObject redPortalPrefab;
    public GameObject bluePortalPrefab;
    public GameObject currentRedPortal;
    public GameObject currentBluePortal;
    public AudioSource portalShootSound;
    public bool debugPortalMode;

    float timeToFire = 0f;
    Transform firepoint;
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
        // uncomment next line to revert to old fire mode
        debugPortalMode = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(fireRate == 0 ){
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
        Vector2 direction = (Vector2)((worldMousePos - firepoint.position));
        direction.Normalize();
        // do raycast, get location of hit
        RaycastHit2D hit = Physics2D.Raycast(firepoint.position, direction);
        if (hit.collider == null)
        {
            return;
        }
        Debug.Log("red raycast hit: " + hit.collider.name);
        Vector3 spawnLocation = hit.collider.gameObject.transform.position;
        spawnLocation.z = 662.0625f;
        GameObject newPortal = Instantiate(redPortalPrefab, spawnLocation, Quaternion.identity);
        
        // so first, gonna copy/paste the reference fixing. i must make a "newPortal" before this section
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

