using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Basic_Enemy : MonoBehaviour
{
    GameObject playerObject;
    NavMeshAgent navAgent;

    public float damageAmount, attackDelay, attackRate, attackDistance, healthAmount;
    
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindWithTag("Player");
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >attackDelay){
            Move();
            if(Vector3.Distance(playerObject.transform.position, transform.position) <= attackDistance){
                Attack();
            }
        }
        else navAgent.destination = transform.position;
        if(healthAmount <= 0f){
            Die();
        }
    }

    void Attack(){
        playerObject.GetComponent<Player_Health>().playerHealth -= damageAmount;
        attackDelay = Time.time + attackRate;
    }

    void Move(){
        navAgent.destination = playerObject.transform.position;
    }

    public void TakeDamage(float amount){
        healthAmount -= amount;
    }

    void Die(){
        navAgent.destination = transform.position;
        Destroy(gameObject, 0.1f);
    }

}
