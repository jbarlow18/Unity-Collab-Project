using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    public int health = 100;
    public int bulletDamage = 10;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            if(health > 10 ){
                health = health - bulletDamage;
                Debug.Log("Health: " + health);
            } else {
                Destroy(gameObject);
            }
        }
    }
}
