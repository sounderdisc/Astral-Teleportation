using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public float fireRate = 0f;
    public LayerMask notToHit;

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
        Debug.Log("shooting on left click");
    }
}

