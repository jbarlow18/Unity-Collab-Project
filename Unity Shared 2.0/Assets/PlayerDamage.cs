using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour
{
    public static int PlayerHealth = 100;
    public int zombieDamage = 10;
    public float delay = 5;
    float timer;
    public GameObject HealthPowerup;
    public GameObject DamagePowerup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When player collides (and stays collided with) with an object
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
            PlayerHealth = 100;
            ZombieHealth.kills = 0;
            SceneManager.LoadScene(0);
        }
    }

    //When player collides with a certain object
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "HealthPowerup")
        {
            if(PlayerDamage.PlayerHealth < 80)
            {
                PlayerDamage.PlayerHealth += 20;
            } else {
                PlayerDamage.PlayerHealth = 100;
            }
            Destroy(HealthPowerup);
        }

        if(collision.gameObject.tag == "DamagePowerup")
        {
            //ZombieHealth.changeDamage(5);
            Destroy(DamagePowerup);
        }

    }

}
