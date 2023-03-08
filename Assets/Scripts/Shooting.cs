using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform pointShoot;
    public GameObject bullet;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, pointShoot.position, transform.rotation);
        }
    }
    
}
