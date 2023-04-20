using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int PlayerHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            if(PlayerHealth > 0 ){
                PlayerHealth = PlayerHealth - 10;
                Debug.Log("PLayer Health: " + PlayerHealth);
            } 
            // else {
            //     Destroy(gameObject);
            // }
        }
    }
}
