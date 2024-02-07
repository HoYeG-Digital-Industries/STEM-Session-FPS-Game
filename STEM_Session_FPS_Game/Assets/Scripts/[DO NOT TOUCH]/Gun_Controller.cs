using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun_Controller : MonoBehaviour
{
    public GameObject bulletObject;
    GameObject firePoint;
    void Start()
    {
        firePoint = GameObject.Find("Fire Point");
    }

    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    void Shoot(){
        GameObject clone = Instantiate(bulletObject, firePoint.transform.position, firePoint.transform.rotation);
        Destroy(clone, 10f);
    }
}
