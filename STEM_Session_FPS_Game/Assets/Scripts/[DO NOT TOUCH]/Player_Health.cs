using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{
    public float playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth <= 0){
            GameOver();
        }
    }

    void GameOver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
