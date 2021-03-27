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
                portalShootSound.Play();
                SpawnRedUsingRaycast();
            }
        }
    }

    void SpawnRedUsingRaycast()
    {
        Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (Vector2)((worldMousePos - this.transform.position));
        direction.Normalize();
        
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, direction, float.PositiveInfinity, validTargets);
        
        Quaternion hitObjectRotation = Quaternion.LookRotation(hit.normal);

        if (hit.collider == null)
        {
            return;
        }
        GameObject newPortal = Instantiate(redPortalPrefab, hit.point, Quaternion.identity);
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
        Debug.Log("Quaternion: x:" + hitObjectRotation[0] + "y:" + hitObjectRotation[1]);
        if(hitObjectRotation[0] < 0){
            Debug.Log("rotating");
            newPortal.transform.Rotate(Vector3.back);
        }
        currentRedPortal = newPortal;
        currentRedPortal.transform.rotation = hitObjectRotation;
        if(hitObjectRotation[0] != 0){
            currentRedPortal.transform.Rotate(new Vector3(90,90,0));
        }
        if(hitObjectRotation[1] != 0){
            currentRedPortal.transform.Rotate(new Vector3(0,90,0));
        }
    }

    // ALL CODE AFTER THIS POINT IS NOT USED, but it may prove useful to keep for debug purposes
    // ##########################################################################################
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

