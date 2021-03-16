using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPortalGun : MonoBehaviour
{
    public float fireRate = 0f;
    public LayerMask notToHit;
    public GameObject redPortalPrefab;
    public GameObject currentRedPortal;

    float timeToFire = 0f;
    Transform firepoint;
    // Start is called before the first frame update
    void Start()
    {
        firepoint = transform.Find("FirePoint");
        if(firepoint == null){
            Debug.Log (" no firepoint found!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(fireRate == 0 ){
            if( Input.GetButtonDown ("Fire1")){
                Shoot();
            }
        }
        else {
            if( Input.GetButton("Fire1") && Time.time > timeToFire){
                timeToFire = Time.time + 1/fireRate;
                Shoot();
            }
        }
    }

    void Shoot() {
        // Debug.Log("shooting on left click");
        // we can change this functionality later, but for now, one step at a time
        SpawnAtCursorLocation();
    }

    void SpawnAtCursorLocation()
    {
        Vector3 spawnLocation = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnLocation.z = 662.0625f;
        GameObject newPortal = Instantiate(redPortalPrefab, spawnLocation, Quaternion.identity);

        // I'm sorry this looks janky, I'm fixing references between the portals. pointers are always unreadable, lol
        // although, in the morning i do need to cover the case where there is no portals in scene already, and when red or when blue exists first
        if (currentRedPortal != null)
        {
            PortalCollision oldPortalScript = currentRedPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;
            PortalCollision newPortalScript = newPortal.GetComponent(typeof(PortalCollision)) as PortalCollision;

            newPortalScript.otherPortal = oldPortalScript.otherPortal;
            newPortalScript.otherPortal.otherPortal = newPortalScript;

            Destroy(currentRedPortal);
            currentRedPortal = newPortal;
        }
    }
}

