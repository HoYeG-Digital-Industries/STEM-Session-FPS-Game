using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Controller : MonoBehaviour
{
    Rigidbody rigidbody;
    public float bulletSpeed;
    public float bulletDamage;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);    
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Enemy")){
            other.gameObject.GetComponent<Basic_Enemy>().TakeDamage(bulletDamage);
        }
    }
}
