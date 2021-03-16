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
        firepoint = transform.FindChild("FirePoint");
        if(firepoint == null){
            Debug.LogError (" no firepoint found!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetButtonDown ("Fire1")){
            Shoot();
        }
    }

    void Shoot() {
        Debug.Log("shooting on left click");
    }
}

