using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public int PlayerHealth = 100;
    public int zombieDamage = 10;
    public float delay = 5;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        
        if(collision.gameObject.tag == "Enemy")
        {
            if(PlayerHealth > 0 ){
                timer += Time.deltaTime;
                if(timer > delay)
                {
                    PlayerHealth = PlayerHealth - zombieDamage;
                    Debug.Log("PLayer Health: " + PlayerHealth);
                    timer = 0;
                }
            }
                
            
        }
        if(PlayerHealth <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
